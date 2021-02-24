# 8 날짜와 시간 처리
DateTime 구조체를 중심으로 날짜와 시각처리 하는 방법을 익힌다.

## 8.1 DataTime 구조체
DataTime 구조체의 인스턴스를 생성하는 주된 방법은 다음과 같은 두 가지이다.
생성자의 인수에 연도, 월, 일을 지정하는 방법, 시, 분, 초를 입력하는 방법이 있다.


### DateTime 객체 생성하기
```CSharp
var dt1 = new DateTime(2021,3,5);
var dt2 = new DateTime(2034, 4, 6, 4, 55, 10);

// Today, Now
var today = DateTime.Today;
var now = DateTime.Now;
```

- Today 속성은 현재 날짜를, Now 속성은 시각정보를 포함한 현재시각을 반환한다.


### DateTime의 속성들
```CSharp
var now = DateTime.Now;
int year = now.Year;
int month = now.Month;
int day = now.Day;
int hour = now.Hour;
int minute = now.Minute;
int second = now.Second;
int millisecond = now.Millisecond;
```