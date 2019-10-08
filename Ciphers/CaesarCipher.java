
public class CaesarCipher implements Cipher {
	
	int key;
	public CaesarCipher(int key)
	{
		this.key = key;
	}
	
	@Override
	public String encrypt(String plainText) {
		int offset = key % 26 + 26;
        StringBuilder encoded = new StringBuilder();
        for (char i : plainText.toCharArray()) {
            if (Character.isLetter(i)) {
                if (Character.isUpperCase(i)) {
                    encoded.append((char) ('A' + (i - 'A' + offset) % 26 ));
                } else {
                    encoded.append((char) ('a' + (i - 'a' + offset) % 26 ));
                }
            } else {
                encoded.append(i);
            }
        }
        return encoded.toString();
	}

	@Override
	public String decrypt(String cipherText) {
		key = 26 - key;
		String plainText = encrypt(cipherText);
		key = 26 + key;
		return plainText;
	}

}
