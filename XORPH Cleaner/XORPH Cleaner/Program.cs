using System;
using System.Diagnostics;
using System.Threading;

namespace XORPH_Cleaner
{
    class Program
    {
        private static MyConsole console = new MyConsole();

		public static void Clean()
		{
			Process process = new Process();

			process.StartInfo.FileName = "cmd.exe";

			process.StartInfo.RedirectStandardInput = true;

			process.StartInfo.RedirectStandardError = true;

			process.StartInfo.RedirectStandardOutput = true;

			process.StartInfo.UseShellExecute = false;

			process.StartInfo.CreateNoWindow = true;

			process.Start();

			process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");

			process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");

			process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");

			process.StandardInput.WriteLine("taskkill /f /im BEService.exe");

			process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");

			process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");

			process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");

			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");

			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");

			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");

			process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");

			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");

			process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\");

			process.StandardInput.WriteLine("exit");
		}
		static void Main(string[] args)
        {

        Menu:
            Console.Title = "XORPH CLEANER | XORPH DEV TEAM";
            Program.console.setColor(ConsoleColor.Green);
            Program.console.smoothWrite("Welcome to the XORPH Cleaner!");
            Program.console.smoothWrite("1. Clean");
            Program.console.smoothWrite("2. Exit");
            string option = Console.ReadLine();
			if(option == "1")
			{
				Console.Clear();
				Program.console.setColor(ConsoleColor.Cyan);
				Program.console.smoothWrite("Cleaning your background apps...");

				Clean();
				Thread.Sleep(9999);
				Program.console.smoothWrite("Cleaned!");
				Thread.Sleep(1000);
				Console.Clear();
				goto Menu;
			}
			else if (option == "2")
			{
				System.Environment.Exit(0);
			}
			else if (option == "69")
			{
				Console.Clear();
				Program.console.smoothWrite("Okay, we get it. 69 is a funny number.");
				Thread.Sleep(2000);
				Console.Clear();
				goto Menu;
			}
			else
			{
				Program.console.setColor(ConsoleColor.Red);
				Console.Clear();
				Console.WriteLine("Wrong Button Stupid!");
				Thread.Sleep(2000);
				Console.Clear();
				goto Menu;
			}
		}
    }
}
