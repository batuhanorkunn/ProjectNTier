using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
	public class AppUserMap : BaseMap<AppUser>
	{
		public AppUserMap()
		{
			ToTable("Kullanıcılar");
			Property(x => x.Username).HasColumnName("Kullanıcı İsmi");
			Property(x => x.Password).HasColumnName("Şifre");
			HasOptional(x => x.UserProfile).WithRequired(x => x.AppUser);
		}
	}
}
