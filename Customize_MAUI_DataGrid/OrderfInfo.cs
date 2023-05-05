using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customize_MAUI_DataGrid
{
	public class OrderInfo : INotifyPropertyChanged
	{
		private int _orderID;
		private string _customerID;
		private string _customer;
		private string _shipCountry;
		private string _shipCity;

		public int OrderID
		{
			get
			{
				return _orderID;
			}
			set
			{
				_orderID = value;
				OnPropertyChanged(nameof(OrderID));
			}
		}

		public string CustomerID
		{
			get
			{
				return _customerID;
			}
			set
			{
				_customerID = value;
				OnPropertyChanged(nameof(CustomerID));
			}
		}

		public string Customer
		{
			get
			{
				return _customer;
			}
			set
			{
				_customer = value;
				OnPropertyChanged(nameof(Customer));
			}
		}

		public string ShipCountry
		{
			get
			{
				return _shipCountry;
			}
			set
			{
				_shipCountry = value;
				OnPropertyChanged(nameof(ShipCountry));
			}
		}

		public string ShipCity
		{
			get
			{
				return _shipCity;
			}
			set
			{
				_shipCity = value;
				OnPropertyChanged(nameof(ShipCity));
			}
		}


		public OrderInfo(int orderID, string customerID, string customer, string shipCountry, string shipCity)
		{
			OrderID = orderID;
			CustomerID = customerID;
			Customer = customer;
			ShipCountry = shipCountry;
			ShipCity = shipCity;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
