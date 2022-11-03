using System;
using System.IO;
using System.Text;

namespace VarianteA
{
    public class Serie1
    {
        public void Insertar(Empleado modelo, string DirDato)
        {
            var resul = File.ReadAllText(DirDato);

            if (string.IsNullOrEmpty(resul))
            {
                var sb = new StringBuilder();
                sb.Append(modelo.DPI);
                sb.Append(modelo.Nombres);
                sb.Append(modelo.Apellidos);

                File.WriteAllText(DirDato, sb.ToString());
            }
        }
    }

    public class Serie2
    {
        public string Bonificacion(decimal salario)
        {
            decimal total = 0;
            if (salario > 25000)
            {

            }
            
            if (salario > 25000)
            {

            }
            
            if (salario > 25000)
            {

            }
            return $"Salario: {salario} | Total: {total}";
        }
    }

    #region Clases auxiliares

    #endregion

    #region Clases modelos
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DPI { get; set; }
    }

    public class Registro
    {
        public DateTime FechaIngreso { get; set; }
        public Empleado EmpleadoDatos { get; set; }
    }
    #endregion
}
