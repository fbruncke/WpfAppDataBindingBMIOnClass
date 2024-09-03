using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDataBindingBMIOnClass.Model
{
    public class BmiModel : INotifyPropertyChanged
    {
		private int height;

		public int Height
		{
			get { return height; }
			set { height = value; 
				this.Changed();
                CalcResult();
            }
		}

        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value;
                this.Changed();
				CalcResult();
            }
        }

        private void CalcResult()
        {
            this.Result = weight / height * height;
        }

        private int result;

		public int Result
		{
			get { return result; }
			set { result = value;
                this.Changed();
            }
		}

		private void Changed([CallerMemberName] String prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
			

		public event PropertyChangedEventHandler? PropertyChanged;
    }
}
