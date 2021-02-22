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