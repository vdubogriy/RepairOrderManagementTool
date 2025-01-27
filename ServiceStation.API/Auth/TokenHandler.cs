using Jose;
using System;

namespace ServiceStation.API.Auth
{
    public class TokenHandler
    {
        public static readonly byte[] SecretKey =
        {
            222, 60, 194, 0, 161, 189, 245, 38, 130, 89, 141, 164, 45, 170, 159, 65, 69, 137, 243, 216, 191, 131, 23,
            250, 32, 45, 231, 117, 37, 158, 225, 180
        };

        public string GenerateToken(object payload)
        {
            var authToken = JWT.Encode(payload, SecretKey, JwsAlgorithm.HS256);
            return authToken;
        }

        public T DecodeToken<T>(string token)
        {
            try
            {
                var retval = JWT.Decode<T>(token, SecretKey);
                return retval;
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}
