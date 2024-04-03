// Keith Evans

using System.Diagnostics.Eventing.Reader;

namespace cipherDecoder
{
    public partial class frmCodeTranslator : Form
    {
        public frmCodeTranslator()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the program.
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all text fields.

            txtInputText.Text = string.Empty;
            txtOutputText.Text = string.Empty;
            txtSecretWord.Text = string.Empty;

        }

        private void btnTranslateText_Click(object sender, EventArgs e)
        {

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string secretWord = txtSecretWord.Text;
            txtOutputText.Text = ""; // Clears the output for each new input.

            char[,] cipherArray = new char[5, 5]; // Create the empty char array for the cipher.

            string cipherAlphabet = new string((secretWord + alphabet).Distinct().ToArray()); // Append the secret word to the beginning and remove duplicate letters.

            cipherAlphabet = cipherAlphabet.Remove(cipherAlphabet.IndexOf('J'), 1); // Remove the letter 'J' from the cipherAlphabet.


            char[] cipherInput = txtInputText.Text.ToArray(); // Take the cipher input and convert it into a char array. 

            // Check for invalid input. Check for empty input boxes.
            if (txtSecretWord.Text == "") {
                MessageBox.Show("The secret word cannot be empty.","Error");
            } else if (txtInputText.Text == "") {
                MessageBox.Show("The input box cannot be empty.", "Error");
            } else { 

            // Populate the cipher array.
            CreateCipherArray(cipherArray, cipherAlphabet);

            // Convert our text into a cipher.
            txtOutputText.Text = DecodeCipher(cipherInput, cipherArray);


            }//else
        }

        static void CreateCipherArray(char[,] cipherArray, string cipherAlphabet) {

            // Create the cipher.
            int cipherAlphabetPosition = 0;
            for (int i = 0; i < cipherArray.GetLength(0); i++) { // Loop each vertical letter.

                for (int j = 0; j < cipherArray.GetLength(1); j++) { // Loop each horizontal letter in the row.

                    //Fill the cipher.
                    cipherArray[i, j] = cipherAlphabet[cipherAlphabetPosition]; // Asign the next letter in the cipherAlphabet to the cipherArray.
                    cipherAlphabetPosition++; // Add count for the next letter in the cipherAlphabet.

                }
            }
        }



        static string DecodeCipher(char[] cipherInput, char[,] cipherArray) {

            string cipherOutput = "";

            foreach (char c in cipherInput) {

                bool matchFound = false;

                // If any words contain J, replace it with I.
                if (c == 'J') {

                    cipherOutput = cipherOutput + 'I';

                } else {

                    // Use the cipher
                    for (int i = 0; i < cipherArray.GetLength(0); i++) { // Loop each vertical letter.

                        for (int j = 0; j < cipherArray.GetLength(1); j++) { // Loop each horizontal letter in the row.

                            if (c == cipherArray[i, j]) {

                                cipherOutput = cipherOutput + cipherArray[j, i];
                                matchFound = true;
                            }

                        }//for int j
                    }//for int i

                    // Check for spaces, numbers, punctuation.
                    if (!matchFound) { // If a match in the cypher is not found, keep the character.
                        cipherOutput += c;
                    }

                }//if, else

            } //foreach

            return cipherOutput;

        }
    }
}
