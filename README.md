# NHoliday
.NET Public Holiday Logic

# Usage

```
DateTime date = new Datetime(2016,1,1);

bool res = Japan.IsHoliday(date);
```

*Notes:* If a specific holiday is moved, this will return true for both the Original date ( e.g. 2016-01-01[original] and 2016-01-02[transferred] )