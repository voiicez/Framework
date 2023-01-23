using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BSAT
{
	public abstract class KayitBase
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		public Guid Guid { get; set; } = Guid.NewGuid();
		public bool isDeleted { get; set; } = false;
	}
}

