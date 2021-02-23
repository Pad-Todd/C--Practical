# Dictionary
2021.02.22
---
## 7. Dictionary - 딕셔너리
   -  Dictionary<Tkey,TValue> 제네릭 클래스는 '해시 테이블'이라는 데이터 구조로 만들어진 클래스이다.
   -  키와 값으로 대응하는 값을 여러개 저장할 수 있는 컬렉션이며 배열, 리스트와 비교하였을 때 키를 사용하여 값을 빠른 속도로 구할 수 있다.
### 7.1.1 Dictionary<TKey, TVAlue>의 조작
```CSharp
// 딕셔너리 초기화 하기 C# 3.0 ver 
var flowerDict = new Dictionary<string, int>()
{
    {"sunflow", 400},
    {"pansy", 300},
    {"tulip", 350},
    {"rose", 500}.
    {"dahila", 450},
};

// C# 6.0 ver
var flowerDict = new Dictionary<string, int>()
{
    ["sunflower"] = 400,
    ["pansy"] = 300,
    ["tulip"] = 350,
    ["rose"] = 500,
    ["dahila"] = 450,
}
```


### 7.1.2 사용자 정의형 객체 값 저장하기
```CSharp
// 딕셔너리의 값(Value)에 사용자가 정의한 클래스의 객체를 저장
var employeeDict = new Dictionary<int, Empolyee>
{
    {100, new Employee(100, "Hello")},
    {111, new Employee(120, "Hi")}
}
```
### 7.1.3 딕셔너리 요소 추가하기
```CSharp
// 딕셔너리 요소 추가
flowerDict["violet"] = 600;
employeeDict[232] = new Employee(3434,"Nice");
// Add 메서드 사용 요소 추가
flower.Add("violet", 600)
employeeDict.Add(123, new Employee(123, "to Meet"))
```
- 딕셔너리에 요소를 추가하는 경우 [] 또는 Add()메서드를 이용하자
- Add()메서드의 경우 이미 키 존재하는 경우 ArgumnetException 예외를 돌려줄 수 도 있다.

### 7.1.4 딕셔너리에서 요소 꺼내기
```CSharp
int price = flowerDict["rose"];
var employee = employeeDict[123];
```
- 딕셔너리에서 요소를 꺼낼 때 배열과 같이 [ ]안에 인덱스 대신 키를 넣어 대응되는 값을 찾을 수 있다.
- 지정한 키가 딕셔너리에 없으면 KeyNotFoundException 예외를 발생한다.

```CSharp
var key = "pansy";
if (flowerDict.ContainsKey(key))
{
    var price = flowerDict[key];
    Console.WriteLine(price);
}
```
- ContainKey 메서드를 이용하면 키가 존재하는지 알 수 있다.

### 7.1.5 딕셔너리 요소 삭제하기
```CSharp
var result = flowerDict.Remove("pansy");
```
- Remove 메서드를 사용하면 딕셔너리 요소를 삭제할 수 있다.
- 요소를 정상적으로 삭제하면 true가 반환되고 그러지 않을 경우 false가 반환된다.

### 7.1.6 딕셔너리에 있는 모든 요소를 꺼낸다.
```CSharp
foreach(KeyValuePair<string, int> item in flowerDict)
    Console.Log("{0} = {1}", item.Key, item.Value);

/// 요소형을 var로 사용하는 것이 일반적이다.
foreach(var item int flowerDict)
    Console.Log("{0} = {1}", item.Key, item.Value);
```
- 배열이나 리스트와 마찬가지로 foreach 문을 사용하여 딕셔너리 값을 모두 가져올 수 있다.
- foreach로 가져 올 때 KeyValuePair<TKey, TValue>형으로 가져오며 요소를 꺼내는 순서는 정해져 있지 않아서 등록한 순서로 나온다는 보장이 없으므로 주의해야한다.

```CSharp
LINQ 사용하기
// 딕셔너리에 저장된 값의 평균 구하기

var average = flowerDict.Average(x => x.Value);
// 딕셔너리에 저장된 값의 합계 구하기
var total = flowerDict.Sum(x => x.Value);
// 필터링
var items = flowerDict.Where(x => x.Key.Length < 5);
```

### 7.1.7 딕셔너리에 있는 모든 키를 꺼낸다.
```CSharp
foreach (var key in flowerDick.Keys)
    Console.WriteLine(key);
- Dictionary<TKey, TValue> 클래스에 있는 Keys 속성을 이용하여 저장된 모든 키를 열거 할 수 있다.
```
---
## 7.2 딕셔너리 응용
- LINQ에 있는  ToDictionary 메서드를 사용하변 배열이나 리스트를 딕셔너리 형으로 변화할 수 있다.

### 7.2.1 딕셔너리로 변환
```CSharp
var employees = new List<Employlee>();
var employeeeDict = employees.ToDictionary(emp => emp.Code);
```

- ToDictionary 메서드에서 첫 번째 인수를 람다식으로 넘겨준다.

- 이 첫 번째 인수가 Key가 되어 해당 객체의 Value로 이용해 딕셔러니를 구성한다.

### 7.2.2 딕셔너리로 부터 다른 딕셔너리를 생성한다.
```CSharp
var flowerDict = new Dictionary<string, int>()
{
    {"sunflower", 400},
    {"pansy", 300},
    {"tulip", 200},
    {"rose", 500},
    {"dahila", 400},
};

var newDict = flowerDict.Where(x => x.Value >= 400)
                        .ToDictionary(flower => flower.Key, flower => flower.Value);

foreach (var item in newDict.Keys)
{
    Console.WriteLine(item);
}
```

- 조건에 의해 일치하는 것만 빼내서 새로운 딕셔너리를 생성할 수 있다.
- 리스트를 딕셔너리로 변환하는 방법과 달리 두 번째 인수에 어떤 객체를 값으로 이용할지 지정할 수 있다.

## 7.2.3 사용자 지정 클래스를 키로 이용
```CSharp
// 예제 클래스
class MonthDay
{
    public int Day { get; private set; }
    public int Month { get; private set; }
    public MonthDay(int month, int day)
    {
        this.Month = month;
        this.Day = day;
    }
    //MonthDay끼리 비교
    public override bool Equals(object obj)
    {
        var other = obj as MonthDay;
        if (other == null)
            throw new ArgumentException();
        return this.Day == other.Day && this.Month == other.Month;
    }
    // 해시코드 
    public override int GetHashCode()
    {
        return Month.GetHashCode() * 31 + Day.GetHashCode();
    }
}

// 사용자 지정 클래스가 Key인 딕셔너리 
var dict = new Dictionary<MonthDay, string>
{
    { new MonthDay(6, 6), "현충일"},
    { new MonthDay(8, 15), "광복절"},
    { new MonthDay(10, 3), "개천절"}
};
var md = new MonthDay(8,15);
var s = dict[md];
Console.WriteLine(s);
```
- 해시코드는 객체의 값을 가지고 일정한 계산을 수행하여 구한 int형 값을 의미하며 딕셔너리의 내부에서는 값을 찾을 때 인덱스로 이용한다.
- 같은 객체로 부터 항상 같은 해시값이 생성되어야 하며, 이 해시값을 통해 분랭의 객체를 복원할 수 없다.
- GatHashCode 메서드에서 31은 해시값이 서로 다르게 퍼지게 하는 의미를 지니며 다른 소수를 사용할 수 도 있다.
- 이제 해시 값이 동일한 경우 Equals메서드를 통해 객체가 같은지 판단 할 수 있다.

## 7.2.4 키 저장

- 딕셔너리 사용시 키에 대응하는 값이 중요하지 않을 때가 있다.
- 이러한 경우 딕서너리와 비슷한 HashSet<T>클래스를 사용해 보자
- HashSet<T>클래스는 Dictionary<TKey, TValue>와 비슷하지만 키 부분만 저장하고 값은 저장하지 않는다는 점이 있다.
- 즉 HashSet<T>클래스는 중복을 허용하지 않는 요소의 집합을 나타낸다.

```CSharp
class WordsExtractor
{
    private string[] _lines;
    
    public WordsExtractor(string[] lines)
    {
        _lines = lines;

    }

    // 10문장 이상인 단어를 중복 없이 알파벳순서로 열거한다.
    public IEnumerable<string> Extract()
    {
        // Hash객체 생성
        var hash = new HashSet<string>();
        foreach (var line in _lines)
        {
            var words = GetWords(line);
            foreach (var word in words)
            {
                if (word.Length >= 10)
                    //hash 단어 등록
                    hash.Add(word.ToLower());
            }
        }
        return hash.OrderBy(s => s);
    }

    // 단어로 분할할 때 사용되는 분리자
    // 문자 배열을 초기화하기보다는 ToCharArray메서드를 사용하는 것이 편하다.
    private char[] _seqarators = @"!?"",.".ToCharArray();

    // 1행부터 단어를 꺼내서 열거한다.
    private IEnumerable<string> GetWords(string line)
    {
        var items = line.Split(_seqarators, StringSplitOptions.RemoveEmptyEntries);
        foreach (var item in items)
        {
            var index = item.IndexOf("'");
            var word = index <= 0 ? item : item.Substrig(0, index);

            if (word.ToLower().All(c => 'a' <= c && c <= 'z'))
                yield return word;
        }
    }
}
```