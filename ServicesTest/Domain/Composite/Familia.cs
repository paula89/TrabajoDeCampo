using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTest.Domain.Composite
{
    public class Familia : FamiliaComponent
	{
		public List<FamiliaComponent> Permisos { get; set; }
		/// <summary>
		/// create a new familia component
		/// </summary>
		public Familia()
		{
			Permisos = new List<FamiliaComponent>();
		}
		/// <summary>
		/// add a familia component in the composite pattern
		/// </summary>
		/// <param name="component"></param>
		public override void Add(FamiliaComponent component)
		{
			Permisos.Add(component);
		}
		/// <summary>
		/// get the childs in the composite pattern
		/// </summary>
		/// <returns></returns>
		public override int GetChilds()
		{
			return Permisos.Count;
		}
		/// <summary>
		/// remove a familia componet in the composite pattern
		/// </summary>
		/// <param name="component"></param>
		public override void Remove(FamiliaComponent component)
		{
			Permisos.RemoveAll(o => o.Nombre == component.Nombre); 
		}
	}
}
