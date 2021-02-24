using System.Collections.Generic;
using System.Collections;
using System.IO;
using System;
namespace Dictionary
{
    class Abbreviations
    {
        // 내부에 딕셔너리를 저장하고 여기에 줄임말과 한국어를 기억한다.
        // 내부에서 이용하는 데이터구조는 공개하지 않는 것이 원칙이기에 private 키워드 선언한다.
        private Dictionary<string, string> _dict = new Dictionary<string, string>();

        // 생성자
        public Abbreviations()
        {
            var lines = File.ReadAllLines("text");
            _dict = lines.Select(lines => lines.Split("="))
                         .ToDictionary(x => x[0], x=> x[1]);
        }

        // Add 메서드
        // Abbrevieations 객체 생성 후 용어를 넣고 싶다면 Add메서드 사용
        public void Adds(string abbr, string korean)
        {
            _dict[abbr] = korean;
        }

        // 인덱서
        // this 키워드를 사용하여 인덱서를 정의한다. 인덱서를 정의하면 Abbreviations객체에 배열처럼 접근할 수 있다.
        // 이 인데서에 줄임말을 지정하면 그에 대응하는 한국어가 반영되며 등록되어 있지 않다면 null반환한다.
        public string this[string abbr]
        {
            get 
            {
                return _dict.Contains(abbr) ? _dict[abbr] : null;
            }
        }

        // FindAll
        // FindAll메서드는 인수로 전달받은 부분 문자열을 포함한 용어를 모두 출력합니다.
        // yield return문은 IEnumerable<T>형을 반환할 때 사용하는 관용구이다.
        // 반복문을 사용해 리스트에 요소를 추가하고 그 리스트를 반환하는 메서드가 있다면 거의 모든 경우 yield return 문으로 대체할 수 있다.
        public IEnumerable<KeyValuePair<string, string>> FindAll(string substring)
        {
            foreach(var item in _dict)
            {
                if(item.Value.Contains(substring))
                    yield return item;
            }
        }
    }
}