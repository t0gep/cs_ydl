using cs_ydl.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_ydl.Services
{
    public class YtdlpService
    {
        public async Task<YtdlpResult> RunAsync(
            string exePath,
            string arguments)
        {
            var psi = new ProcessStartInfo
            {
                FileName = exePath,
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var proc = Process.Start(psi)!;

            string stdout = await proc.StandardOutput.ReadToEndAsync();
            string stderr = await proc.StandardError.ReadToEndAsync();

            await proc.WaitForExitAsync();

            return new YtdlpResult
            {
                ExitCode = proc.ExitCode,
                StdOut = stdout,
                StdErr = stderr
            };
        }
    }
}
