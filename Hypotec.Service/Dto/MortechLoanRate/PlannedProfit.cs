using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Hypotec.Service.Dto.MortechLoanRate
{
	[XmlRoot(ElementName = "planned_profit")]
	public class PlannedProfit
	{

		[XmlAttribute(AttributeName = "profit_percent")]
		public double ProfitPercent { get; set; }

		[XmlAttribute(AttributeName = "profit_dollar")]
		public double ProfitDollar { get; set; }
	}
}
