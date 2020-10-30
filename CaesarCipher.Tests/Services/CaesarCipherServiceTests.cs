using CaesarCipher.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher.Tests.Services
{
    [TestFixture]
    class CaesarCipherServiceTests
    {
        [Test]
        public void Encrypt_WithEmptyMessage_ReturnsEmptyDecryptedMessage()
        {
            //Arrange
            string message = "";
            int key = 5;
            string expectedEncryptedMessage = "";

            //Act
            string actualEncryptedMessage = CaesarCipherService.Encrypt(message, key);

            //Assert
            Assert.AreEqual(expectedEncryptedMessage, actualEncryptedMessage);
        }

        [Test]
        public void Decrypt_WithEmptyMessage_ReturnsEmptyDecryptedMessage()
        {
            //Arrange
            string message = "";
            int key = 5;
            string expectedDecryptedMessage = "";

            //Act
            string actualDecryptedMessage = CaesarCipherService.Decrypt(message, key);

            //Assert
            Assert.AreEqual(expectedDecryptedMessage, actualDecryptedMessage);
        }

        [Test]
        public void Encrypt_WithNotEmptyMessageAndWithoutOverflow_ReturnsEncryptedMessage()
        {
            //Arrange
            string message = "hello";
            int key = 5;
            string expectedEncryptedMessage = "mjqqt";

            //Act
            string actualEncryptedMessage = CaesarCipherService.Encrypt(message, key);

            //Assert
            Assert.AreEqual(expectedEncryptedMessage, actualEncryptedMessage);
        }

        [Test]
        public void Decrypt_WithNotEmptyMessageAndWithoutOverflow_ReturnsDecryptedMessage()
        {
            //Arrange
            string message = "mjqqt";
            int key = 5;
            string expectedDecryptedMessage = "hello";

            //Act
            string actualDecryptedMessage = CaesarCipherService.Decrypt(message, key);

            //Assert
            Assert.AreEqual(expectedDecryptedMessage, actualDecryptedMessage);
        }

        [Test]
        public void Encrypt_WithNotEmptyMessageAndWithOverflow_ReturnsEncryptedMessage()
        {
            //Arrange
            string message = "hello";
            int key = 261;
            string expectedEncryptedMessage = "mjqqt";

            //Act
            string actualEncryptedMessage = CaesarCipherService.Encrypt(message, key);

            //Assert
            Assert.AreEqual(expectedEncryptedMessage, actualEncryptedMessage);
        }

        [Test]
        public void Decrypt_WithNotEmptyMessageAndWithOverflow_ReturnsDecryptedMessage()
        {
            //Arrange
            string message = "mjqqt";
            int key = 261;
            string expectedDecryptedMessage = "hello";

            //Act
            string actualDecryptedMessage = CaesarCipherService.Decrypt(message, key);

            //Assert
            Assert.AreEqual(expectedDecryptedMessage, actualDecryptedMessage);
        }

        [Test]
        public void EncryptAndDecrypt_WithoutOverflow_ReturnsSameMessage()
        {
            //Arrange
            string message = "Hello world! It's me :)";
            int key = 7;

            //Act
            string encryptedMessage = CaesarCipherService.Encrypt(message, key);
            string decryptedMessage = CaesarCipherService.Decrypt(encryptedMessage, key);

            //Assert
            Assert.AreEqual(message, decryptedMessage);
        }

        [Test]
        public void EncryptAndDecrypt_WithoutOverflowAndWithNegativeKey_ReturnsSameMessage()
        {
            //Arrange
            string message = "Hello world! It's me :)";
            int key = -7;

            //Act
            string encryptedMessage = CaesarCipherService.Encrypt(message, key);
            string decryptedMessage = CaesarCipherService.Decrypt(encryptedMessage, key);

            //Assert
            Assert.AreEqual(message, decryptedMessage);
        }

        [Test]
        public void EncryptAndDecrypt_WithOverflow_ReturnsSameMessage()
        {
            //Arrange
            string message = "Hello world! It's me :)";
            int key = 129562;

            //Act
            string encryptedMessage = CaesarCipherService.Encrypt(message, key);
            string decryptedMessage = CaesarCipherService.Decrypt(encryptedMessage, key);

            //Assert
            Assert.AreEqual(message, decryptedMessage);
        }
    }
}
