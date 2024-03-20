namespace TestValidacion
{
    public class UnitTest1
    {
        [Fact]
        public void ValidacionPassword()
        {
            string password = "test";
            ValidacionContraseña validador = new ValidacionContraseña();
            bool Validacion = validador.ContraseñaValidar(password);
            Assert.False(Validacion);
        }

        [Fact]
        public void ValidacionPassword_CaracteresSpecialesRequeridos()
        {
            string password = "test123";
            ValidacionContraseña validador = new ValidacionContraseña();
            bool Validacion = validador.ContraseñaValidar(password);
            Assert.False(Validacion);
        }
    }

    internal class ValidacionContraseña
    {
        public bool ContraseñaValidar(string password)
        {
            return password.Length >= 8 && ContieneCaracteresEspeciales(password);
        }

        private bool ContieneCaracteresEspeciales(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
