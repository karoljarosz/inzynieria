using System;
using System.Runtime.Serialization;
namespace TripsService {
	/// <summary>
	/// Klasa służąca do identyfikacji osoby zalogowanej
	/// </summary>
    public class AuthAdapter{
        /// <summary>
        /// Dane zalogowanego użytkownika
        /// </summary>
		private User identity = null;

        private static AuthAdapter Identity = new AuthAdapter();
		/// <summary>
		/// Defaultowy konstruktor
		/// </summary>
        private AuthAdapter() {
		}
        /// <summary>
        /// Zwracamy instancję obiektu
        /// </summary>
        /// <returns>Obiekt authAdapter</returns>
		public static AuthAdapter GetInstance() {
            return AuthAdapter.Identity;
		}
        /// <summary>
        /// Pobranie zalogowanego użytkownika
        /// </summary>
        /// <returns></returns>
        public User getIdentity() {
            return this.identity;
        }
        /// <summary>
        /// Dodajemy dane do przechowywania sesji
        /// </summary>
        /// <param name="identity">Zalogowany user</param>
		public void WriteIdentity(User identity) {
            this.identity = identity;
		}
        /// <summary>
        /// Czyścimy dane o użytkowniku
        /// </summary>
		public void ClearIdentity() {
            this.identity = null;
		}



        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

}
