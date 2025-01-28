using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Extensions
{
	public static class GetEnumValues
	{

		public static List<SelectListItem> EnumValues<T>()
		{
			var values= Enum.GetValues(typeof(T));
			var SelectList= new List<SelectListItem>();
			foreach(var item in values)
			{
				SelectList.Add(new SelectListItem
				{
					Text = item.ToString(),
					Value = item.ToString()
				});
			}

			return SelectList;
		}
	}
}
