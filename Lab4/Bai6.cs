using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	public partial class Bai6 : Form
	{
		public Bai6()
		{
			InitializeComponent();
			HtmlWeb htmlWeb = new HtmlWeb();
			var htmlDoc = htmlWeb.Load("https://vnexpress.net/the-gioi/tu-lieu");

			var articles = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"automation_TV0\"]/div[2]/article");
			foreach ( var article in articles )
			{
				var title = article.SelectSingleNode("./h2");
				var description = article.SelectSingleNode("./p");
			}
		}
	}
}
