   public static void SubSet(string text, char startChar, char endChar)
        {
            string startToEndDirection = string.Empty;
            string EndToStartDirection = string.Empty;

            int firstA = -1;
            int lastB = -1;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == startChar && firstA == -1)
                {
                    firstA = i;
                }
                if (text[text.Length - 1 - i] == endChar && lastB == -1)
                {
                    lastB = text.Length - 1 - i;

                }
                if (firstA != -1)
                {
                    startToEndDirection += text[i];
                    if (text[i] == endChar && i != lastB)
                        Console.WriteLine(startToEndDirection); //yield startToEndDirection
                }
                if (lastB != -1)
                {
                    EndToStartDirection = text[text.Length - 1 - i] + EndToStartDirection;
                    if (text[text.Length - 1 - i] == startChar)
                    {

                        Console.WriteLine(EndToStartDirection);//yield EndToStartDirection
                    }
                }

            }
        }
