using System;
using System.Security.Cryptography;

namespace PasswordGenerator
{
    public static class Crypto
    {
        // The random number provider.
        private static RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();

        // Return a random integer between a min and max value.
        public static int RandomInteger(int min, int max)
        {
            var scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                // Get four random bytes.
                var fourBytes = new byte[4];
                Rand.GetBytes(fourBytes);

                // Convert that into an uint.
                scale = BitConverter.ToUInt32(fourBytes, 0);
            }
            // Add min to the scaled difference between max and min.
            return (int)(min + (max - min) * (scale / (double)uint.MaxValue));
        }
    }
}
