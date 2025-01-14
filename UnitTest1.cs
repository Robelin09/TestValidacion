namespace TestValidacion
{
    public class UnitTest1
    {
        [Fact]
        public void ValidacionPassword()
        {
            string password = "test";
            ValidacionContraseņa validador = new ValidacionContraseņa();
            bool Validacion = validador.ContraseņaValidar(password);
            Assert.False(Validacion);
        }

        [Fact]
        public void ValidacionPassword_CaracteresSpecialesRequeridos()
        {
            string password = "test123";
            ValidacionContraseņa validador = new ValidacionContraseņa();
            bool Validacion = validador.ContraseņaValidar(password);
            Assert.False(Validacion);
        }
    }

    internal class ValidacionContraseņa
    {
        public bool ContraseņaValidar(string password)
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
