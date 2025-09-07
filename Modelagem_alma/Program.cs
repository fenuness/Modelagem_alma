using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

Console.WriteLine("Hello, World!");


namespace Alma
{
    internal class Usuario
    {
        [Key] // PRIMARY KEY
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // AUTOINCREMENT
        public int cd_cliente { get; set; }

        [Required] // NOT NULL
        [StringLength(150)]
        public string nome_completo { get; set; } = string.Empty;

        [Required] // NOT NULL
        [StringLength(15)]
        public string telefone { get; set; } = string.Empty;

        [Required] // NOT NULL
        [StringLength(11)]
        public string cpf { get; set; } = string.Empty;

        [Required] // NOT NULL
        [StringLength(8)]
        public string cep { get; set; } = string.Empty;

        [Required] // NOT NULL
        [StringLength(8)]
        public string senha { get; set; } = string.Empty;
    }


    public class Campanha
    {
        [Key] // PRIMARY KEY
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // AUTOINCREMENT
        public int cd_campanha { get; set; }

        [Required] // NOT NULL
        [StringLength(100)]
        public string nome_campanha { get; set; } = string.Empty;

        [Required] // NOT NULL
        [Column(TypeName = "decimal(18,2)")] // DECIMAL no banco
        public decimal meta_arrecadacao { get; set; }

        [Required] // NOT NULL
        public DateTime inicio { get; set; }

        [Required] // NOT NULL
        public DateTime fim { get; set; }
    }


    internal class Doacao
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string cd_doacao { get; set; }

        // FK para Usuario
        [Required]
        public int cd_cliente { get; set; } // coluna FK
        [ForeignKey("cd_cliente")]
        public Usuario Usuario { get; set; } = null!; // navegação para Usuario

        // FK para Campanha
        [Required]
        public int cd_campanha { get; set; } // coluna FK
        [ForeignKey("cd_campanha")]
        public Campanha Campanha { get; set; } = null!; // navegação para Campanha

        [Required]
        [StringLength(35)]
        public string nome_doacao { get; set; }

        [Required]
        [StringLength(25)]
        public string tipo_doacao { get; set; }

        [Required]
        [StringLength(30)]

        public string forma_arrecadacao { get; set; }


        [Required]
        [StringLength(30)]

        public string status_arrecadacao { get; set; }

    }
}