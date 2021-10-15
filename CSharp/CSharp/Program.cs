using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Harry Potter";

            // 1. 찾기
            bool found = name.Contains("Harry"); // 있으면 true 없으면 false
            int index = name.IndexOf("P");      // 없다면 -1 반환


            // 2. 변형
            name = name + "Junior"; // 더하기 (추가)
            string lowerCaseName = name.ToLower();  // 전부다 소문자로 바꾸기
            string upperCaseName = name.ToUpper();  // 전부다 대문자 바꾸기
            string newName = name.Replace('r', 'l'); // r을 l로 바꾸기(치환)

            // 3. 분할
            string[] names = name.Split(new char[] { ' ' });    // ' '공백을 기준으로 분리해서 string 배열에 넣기
            string substringName = name.Substring(5);   // 5번째 인덱스부터 잘라서 5~끝까지 문자열 저장
        }
    }
}
