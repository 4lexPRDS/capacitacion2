using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace CapaVista_PaqueteCRUD.Ayudas
{
    public class ValidadorFormulario
    {
        private readonly ValidationContext contexto;
        private readonly List<ValidationResult> errores;
        private readonly bool esValido;

        public ValidadorFormulario(object instancia)
        {
            contexto = new ValidationContext(instancia);
            errores = new List<ValidationResult>();
            esValido = Validator.TryValidateObject(instancia, contexto, errores, true);
        }

        public bool EsValido()
        {
            if (!esValido)
            {
                string texto = string.Empty;
                foreach (ValidationResult item in errores)
                {
                    texto += item.ErrorMessage + "\n";
                }
                MessageBox.Show(texto, "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return esValido;
        }
    }
}
