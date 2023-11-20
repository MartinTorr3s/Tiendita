namespace Tiendita.ReglasdeNegocio.PersonalException
{
    public class DBMySqlException : Exception
    {

        public int Number { get; private set; }
        public string MessageError { get; private set; }
        public DBMySqlException(int number, string message)
        {

            if (number == 1045) { Number = 401; MessageError = "Usuario o contraseña inválido."; }

            if (number == 1042) { Number = 503; MessageError = "El servidor no es accesible."; }

            if (number == 1049) { Number = 404; MessageError = "La base de datos no existe."; }

            else { Number = number; MessageError = message; }

        }
    }
}
