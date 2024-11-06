## 8.Introduce Local Extension

### ���뱾����չ

C#: ��ר�ŵ� extension method



������ʹ�õķ���������Ҫ��������ķ��������㲻���޸ĸ��ࡣ

����һ��������Щ���ⷽ�������ࡣʹ�����չ���Ϊԭʼ���������װ�ࡣ


#### ����

������߲���ȫ֪ȫ�ܣ����ǿ���û��Ϊ���ṩ���õķ��������������޸�Դ���룬ͨ����õķ�������Ӹ÷�����Ȼ������ͨ�������޸�Դ���롣�����ֻ��Ҫһ��������������ʹ����������������Introduce Foreign Method�������ǣ�һ������Ҫ�ķ����������������Ǿͻ������Թ�����ˣ�����Ҫ����Щ�������鵽һ�������λ�á���׼������������������໯�Ͱ�װ����ʵ����һĿ������Է���������������£��ҳ�������װ��Ϊ������չ��

������չ��һ���������࣬����������չ��������͡�����ζ����֧��ԭʼ������й��ܣ����һ�����˶���Ĺ��ܡ������ʵ����������չ��ʹ������������ʹ��ԭʼ�ࡣ

ͨ��ʹ�ñ�����չ���������ѭ�����������ݴ�������õ�Ԫ��ԭ������㲻�Ͻ���������������У�����Щ����Ӧ������չ�У������ջ�ʹ�����ิ�ӻ�����ʹ��Щ�����������á�

��ѡ������Ͱ�װ��֮��ʱ����ͨ����ϲ�����࣬��Ϊ���Ĺ��������١����������ϰ�������Ҫ�ڶ��󴴽�ʱӦ�á�����ҿ��Խӹܴ������̣��Ǿ�û���⡣��������Ժ�Ӧ�ñ�����չ������ͳ����ˡ����໯��ʹ�Ҵ�����������¶�����������������þɶ����Ҿ�����������ԭʼ���ݵĶ������ԭʼ�����ǲ��ɱ�ģ��Ǿ�û���⣻�ҿ��԰�ȫ�ظ������������ԭʼ������Ը��ģ��ͻ������⣬��Ϊһ������ĸ��Ĳ���Ӱ����һ�������ұ���ʹ�ð�װ�ࡣ������ͨ��������չ���еĸ��Ļ�Ӱ��ԭʼ���󣬷�֮��Ȼ��

#### �ŵ�

+ **��ǿ����**�������ڲ��޸�ԭʼ���������������Ĺ��ܡ�
+ **�����ظ�����**��ͨ��������ķ���������һ����չ���У����Լ��ٴ����ظ���
+ **��ߴ����ά����**������صķ���������һ�����У�ʹ���������ά������⡣

#### ����

+ **���Ӹ�����**�����뱾����չ���ܻ����Ӵ���ĸ����ԣ��ر����ڴ����װ��ʱ��
+ **����������**�����ԭʼ�෢���仯��������Ҫ��������ʹ�ñ�����չ�Ĵ��롣

### ʾ����ʹ������

���ȣ��Ҵ���һ���µ��������ࣺ

```java
class MfDateSub extends Date
```

���������Ҵ������ں���չ֮���ת����ԭʼ��Ĺ��캯����Ҫ�ü򵥵�ί�����ظ���

```java
public MfDateSub(String dateString) {
    super(dateString);
}
```

���ڣ������һ��ת�����캯����������һ��ԭʼ������Ϊ������

```java
public MfDateSub(Date arg) {
    super(arg.getTime());
}
```

���ڣ��ҿ�������չ����¹��ܣ���ʹ���ƶ�������Move Method�����κ����������Ƶ���չ�У�

```java
client class...
private static Date nextDay(Date arg) {
    // foreign method, should be on date
    return new Date(arg.getYear(), arg.getMonth(), arg.getDate() + 1);
}

becomes

class MfDateSub...
Date nextDay() {
    return new Date(getYear(), getMonth(), getDate() + 1);
}
```

### ʾ����ʹ�ð�װ��

���ȣ���������װ�ࣺ

```java
class mfDateWrap {
    private Date _original;
}
```

ʹ�ð�װ����ʱ������Ҫ�Բ�ͬ�ķ�ʽ���ù��캯����ԭʼ���캯��ͨ���򵥵�ί��ʵ�֣�

```java
public MfDateWrap(String dateString) {
    _original = new Date(dateString);
}
```

ת�����캯������ֻ����ʵ��������

```java
public MfDateWrap(Date arg) {
    _original = arg;
}
```

Ȼ����ί��ԭʼ�����з����ķ���������ֻչʾ������

```java
public int getYear() {
    return _original.getYear();
}

public boolean equals(Object arg) {
    if (this == arg) return true;
    if (!(arg instanceof MfDateWrap)) return false;
    MfDateWrap other = (MfDateWrap) arg;
    return _original.equals(other._original);
}
```

�����Щ���ҿ���ʹ���ƶ�������Move Method���������ض�����Ϊ�ŵ������У�

```java
client class...
private static Date nextDay(Date arg) {
    // foreign method, should be on date
    return new Date(arg.getYear(), arg.getMonth(), arg.getDate() + 1);
}

becomes

class MfDateWrap...
Date nextDay() {
    return new Date(getYear(), getMonth(), getDate() + 1);
}
```

### C# ����

�������ǽ���������ת��ΪC#���룬����ӱ�Ҫ��ģ���ࡣ

#### ʹ������(�̳�)��ʾ��

```java
using System;

public class MfDateSub : DateTime {
    public MfDateSub(string dateString) : base(DateTime.Parse(dateString).Ticks) { }

    public MfDateSub(DateTime arg) : base(arg.Ticks) { }

    public DateTime NextDay() {
        return new DateTime(Year, Month, Day + 1);
    }
}

public class Program {
    public static void Main() {
        DateTime previousEnd = new DateTime(2023, 10, 21);
        MfDateSub newDate = new MfDateSub(previousEnd);
        DateTime nextDay = newDate.NextDay();

        Console.WriteLine(nextDay.ToString("yyyy-MM-dd"));
    }
}
```

#### ʹ�ð�װ��(װ����ģʽ)��ʾ��

```java
using System;

public class MfDateWrap {
    private DateTime _original;

    public MfDateWrap(string dateString) {
        _original = DateTime.Parse(dateString);
    }

    public MfDateWrap(DateTime arg) {
        _original = arg;
    }

    public int Year {
        get { return _original.Year; }
    }

    public int Month {
        get { return _original.Month; }
    }

    public int Day {
        get { return _original.Day; }
    }

    public DateTime NextDay() {
        return new DateTime(Year, Month, Day + 1);
    }

    public override bool Equals(object obj) {
        if (this == obj) return true;
        if (!(obj is MfDateWrap)) return false;
        MfDateWrap other = (MfDateWrap)obj;
        return _original.Equals(other._original);
    }
}

public class Program {
    public static void Main() {
        DateTime previousEnd = new DateTime(2023, 10, 21);
        MfDateWrap newDate = new MfDateWrap(previousEnd);
        DateTime nextDay = newDate.NextDay();

        Console.WriteLine(nextDay.ToString("yyyy-MM-dd"));
    }
}
```

���������Ǿ�����˽������뱾����չ��������ʾ�����뷭������Ĳ�ת��ΪC#���롣



��Ȼ����������һ�´����еı�������

### ʹ�������ʾ��

1. **previousEnd**: ����һ�� `DateTime` ���͵ı��������ڴ洢��һ���Ʒ����ڵĽ������ڡ�
2. **newDate**: ����һ�� `MfDateSub` ���ʵ�������ڱ�ʾ��չ������ڶ���
3. **nextDay**: ����һ�� `DateTime` ���͵ı��������ڴ洢��������һ������ڡ�
4. **MfDateSub**: ����һ���̳��� `DateTime` �����࣬����˶���ķ������� `NextDay`��
5. **NextDay**: ���� `MfDateSub` ���е�һ�����������ڼ���������ڵ���һ�졣

### ʹ�ð�װ���ʾ��

1. **_original**: ����һ�� `DateTime` ���͵ı��������ڴ洢ԭʼ�����ڶ���
2. **Year**: ����һ�����ԣ����ڻ�ȡ `_original` ���ڶ������ݡ�
3. **Month**: ����һ�����ԣ����ڻ�ȡ `_original` ���ڶ�����·ݡ�
4. **Day**: ����һ�����ԣ����ڻ�ȡ `_original` ���ڶ�������ڡ�
5. **NextDay**: ���� `MfDateWrap` ���е�һ�����������ڼ���������ڵ���һ�졣
6. **Equals**: ���� `MfDateWrap` ���е�һ�����������ڱȽ����� `MfDateWrap` �����Ƿ���ȡ�

ͨ����Щ�����ͷ��������ǿ��Ը�������������Ľṹ�͹��ܡ�

### ʹ����չ���� (C#)

```cs
DateTime NextDay(this DateTime date);
```

C# ����, ��д��: https://ctrlshift.dev/introduce-local-extension/
