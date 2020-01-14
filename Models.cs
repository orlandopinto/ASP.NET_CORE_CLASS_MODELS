using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CORE_CLASS_MODELS
{
	public class Models
	{
	}
	public class Establecimientos
	{
		[Key]
		public int EstablecimientoID { get; set; }
		[Required]
		public int UserID { get; set; }
		public string Establecimiento { get; set; }
		[Required, MaxLength(50)]
		public string Email { get; set; }
		[Required, MaxLength(150)]
		public string WebSite { get; set; }
		[MaxLength(150)]
		public string Direccion { get; set; }
		[Required, MaxLength(50)]
		public string NIF { get; set; }
		[Required, MaxLength(50)]
		public string Telefonos { get; set; }
		[MaxLength(150)]
		public string Acerca_de { get; set; }
		[MaxLength(50)]
		public string Mapa { get; set; }
	}

	public class Fotos
	{
		[Key]
		public int FotoID { get; set; }
		public int EstablecimientoID { get; set; }
		[MaxLength(100)]
		public string Ruta_Foto { get; set; }
		[ForeignKey(@"EstablecimientoID")]
		public virtual Establecimientos Establecimientos { get; set; }
	}

	public class Meta_data
	{
		[Key]
		public int MetadataID { get; set; }
		public int EstablecimientoID { get; set; }
		public string Metadata { get; set; }
		[ForeignKey(@"EstablecimientoID")]
		public virtual Establecimientos Establecimientos { get; set; }
	}

	public class Paises
	{
		[Key]
		public int PaisID { get; set; }
		[Required, MaxLength(50)]
		public string Pais { get; set; }
	}

	public class Regiones
	{
		[Key]
		public int RegionID { get; set; }
		public int PaisID { get; set; }
		[Required, MaxLength(50)]
		public string Region { get; set; }
		[ForeignKey(@"PaisID")]
		public virtual Paises Paises { get; set; }
	}

	public class Estados
	{
		[Key]
		public int EstadoID { get; set; }
		public int RegionID { get; set; }
		[Required, MaxLength(50)]
		public string Estado { get; set; }
		[ForeignKey(@"RegionID")]
		public virtual Regiones Regiones { get; set; }
	}

	public class Municipios
	{
		[Key]
		public int MunicipioID { get; set; }
		public int EstadoID { get; set; }
		[Required, MaxLength(50)]
		public string Municipio { get; set; }
		[ForeignKey(@"EstadoID")]
		public virtual Estados Estados { get; set; }
	}

	public class Rel_Categoria_Servicio
	{
		[Key]
		public int CategoriaID { get; set; }
		[Key]
		public int ServicioID { get; set; }
	}

	public class Categorias
	{
		[Key]
		public int CategoriaID { get; set; }
		[Required, MaxLength(50)]
		public string Categoria { get; set; }
		[Required, MaxLength(50)]
		public string Descripcion { get; set; }
		public Nullable<bool> Activo { get; set; }
	}

	public class Servicios
	{
		[Key]
		public int ServicioID { get; set; }
		public int CategoriaID { get; set; }
		[Required, MaxLength(50)]
		public string Servicio { get; set; }
		[Required, MaxLength(50)]
		public string Descripcion { get; set; }
		public Nullable<bool> Activo { get; set; }

		[ForeignKey(@"CategoriaID")]
		public virtual Categorias Categorias { get; set; }
	}
}
