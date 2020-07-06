using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace App299
{
	class MonkeyItem
	{
		public string Name {get; set;}
	

		public ImageSource Image { get; set; }

	}


	class MainViewModel
	{
		public ObservableCollection<MonkeyItem> ItemsSource { get; set; }


		public MainViewModel()
		{
			var monkeyList = new List<MonkeyItem>()
			{
				new MonkeyItem () { Name="Baboon", Image = ImageSource.FromFile("monkey.jpg") },
				new MonkeyItem () { Name="Capuchin Monkey Capuchin MonkeyCapuchin MonkeyCapuchin MonkeyCapuchin MonkeyCapuchin MonkeyCapuchin MonkeyCapuchin Monkey", Image = ImageSource.FromFile("monkey.jpg") },
				new MonkeyItem () { Name="Blue Monkey. Yeah, monkeys can be blue!", Image = ImageSource.FromFile("monkey.jpg") },
				new MonkeyItem () { Name="Spider Monkey", Image = ImageSource.FromFile("monkey.jpg") },
				new MonkeyItem () { Name="Pygmy Marmoset, pretty small fella", Image = ImageSource.FromFile("monkey.jpg") }
			};


			ItemsSource = new ObservableCollection<MonkeyItem>(monkeyList);

		}

	}
}
