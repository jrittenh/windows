﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TerraMap.Data;

namespace TerraMap.Data
{
	public class ObjectInfoSetViewModel : ObjectInfoViewModel
	{
		private ObservableCollection<ObjectInfoViewModel> objectInfoViewModels = new ObservableCollection<ObjectInfoViewModel>();

		public ObservableCollection<ObjectInfoViewModel> ObjectInfoViewModels
		{
			get { return objectInfoViewModels; }
			set
			{
				objectInfoViewModels = value;
				RaisePropertyChanged();
			}
		}
	}
}
