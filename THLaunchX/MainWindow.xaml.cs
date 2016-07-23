using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace THLaunchX
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public static void startGame(string gameNum) {
			string gamePath = getGamePath(gameNum);
			
		}

		public static string getGamePath(string gameNum)
		{
			string gamePath;
			switch (gameNum)
			{
				case "TH06":
					gamePath = Properties.Settings.Default.th06_path;
					break;
				case "TH07":
					gamePath = Properties.Settings.Default.th07_path;
					break;
				case "TH075":
					gamePath = Properties.Settings.Default.th075_path;
					break;
				case "TH08":
					gamePath = Properties.Settings.Default.th08_path;
					break;
				case "TH09":
					gamePath = Properties.Settings.Default.th09_path;
					break;
				case "TH095":
					gamePath = Properties.Settings.Default.th095_path;
					break;
				case "TH10":
					gamePath = Properties.Settings.Default.th10_path;
					break;
				case "TH105":
					gamePath = Properties.Settings.Default.th105_path;
					break;
				case "TH11":
					gamePath = Properties.Settings.Default.th11_path;
					break;
				case "TH12":
					gamePath = Properties.Settings.Default.th12_path;
					break;
				case "TH123":
					gamePath = Properties.Settings.Default.th123_path;
					break;
				case "TH125":
					gamePath = Properties.Settings.Default.th125_path;
					break;
				case "TH128":
					gamePath = Properties.Settings.Default.th128_path;
					break;
				case "TH13":
					gamePath = Properties.Settings.Default.th13_path;
					break;
				case "TH135":
					gamePath = Properties.Settings.Default.th135_path;
					break;
				case "TH14":
					gamePath = Properties.Settings.Default.th14_path;
					break;
				case "TH143":
					gamePath = Properties.Settings.Default.th143_path;
					break;
				case "TH145":
					gamePath = Properties.Settings.Default.th145_path;
					break;
				case "TH15":
					gamePath = Properties.Settings.Default.th15_path;
					break;
				default:
					gamePath = "";
					Console.WriteLine("gamePathGetError!");
					break;
			}
			return gamePath;
		}

		private void Start(object sender, RoutedEventArgs e)
		{
			Console.WriteLine(((Button)sender).Name.ToString());
		}

		private void Menu_Setting_Click(object sender, RoutedEventArgs e)
		{
			var settingWindow = new SettingWindow();
			settingWindow.Show();
		}
	}
}
