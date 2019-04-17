using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace AutoUpdater.NET
{
    public class AutoUpdater
    {
        private Form _updaterForm;

        private readonly string _versionFileText;
        private readonly string _versionUrl;

        private readonly VersionInfo[] _versionArray;
        private readonly Version _currentVersion;

        public AutoUpdater(string versionsUrl, Version currentAssemblyVersion)
        {
            _versionUrl = versionsUrl ?? throw new ArgumentNullException(nameof(versionsUrl));
            _currentVersion = currentAssemblyVersion;
            _versionFileText = DownloadVersionFile();

            if (_versionFileText == null) return;

            _versionArray = CreateVersionList();

            var newVersion = GetNewVersionInfo();
            if (newVersion == null) return; // current version is equal to or greater than latest version

            if (newVersion.Mandatory == true && newVersion.MandatoryStyle?.ForceUpdate == true)
                DownloadNewVersion(newVersion);
            else
            {
                _updaterForm = new UpdateForm(_currentVersion.ToString(), newVersion.VersionNumber, newVersion.Changelog, newVersion.Mandatory == true);
                var result = _updaterForm.ShowDialog();

                if (result == DialogResult.OK)
                    DownloadNewVersion(newVersion);
            }
        }

        private VersionInfo GetNewVersionInfo()
        {
            var latestVersionInfo = _versionArray[0];
            var latestMandatoryVersionInfo = _versionArray.OrderBy(v => v.Mandatory).ToArray()[0]; // false after true

            if (!Version.TryParse(latestVersionInfo.VersionNumber, out var latestVersion))
            {
                throw new ArgumentException("Invalid version file specified. Unable to parse version number. Ensure it is in the format 'X.X.X.X', similar to an IPv4 address.");
            }

            if (latestMandatoryVersionInfo != latestVersionInfo)
            {
                if (!Version.TryParse(latestMandatoryVersionInfo.VersionNumber, out var latestMandatoryVersion))
                {
                    throw new ArgumentException("Invalid version file specified. Unable to parse version number. Ensure it is in the format 'X.X.X.X', similar to an IPv4 address.");
                }

                if (latestMandatoryVersion < latestVersion)
                {
                    latestVersion = latestMandatoryVersion;
                    latestVersionInfo = latestMandatoryVersionInfo;
                }
            }

            return latestVersion <= _currentVersion ? null : latestVersionInfo;
        }

        private void DownloadNewVersion(VersionInfo newVersionInfo)
        {
            var exePath = Application.ExecutablePath;
            var newExePath = exePath.Substring(0, exePath.Length - 4) + "-BEFORE-UPDATE.exe";

            File.Copy(exePath, newExePath, true);

            var process = new ProcessStartInfo(newExePath, $"--autoupdaterdotnet \"{Uri.EscapeDataString(newVersionInfo.DownloadUrl)}\"");
            Process.Start(process);

            Application.Exit();
        }

        private string DownloadVersionFile()
        {
            using (var client = new WebClient())
            {
                try
                {
                    return client.DownloadString(_versionUrl);
                }
                catch (WebException)
                {
                    return null;
                }
            }
        }

        private VersionInfo[] CreateVersionList()
        {
            return VersionInfo.FromJson(_versionFileText).OrderByDescending(c => c.VersionNumber).ToArray();
        }
    }

}
