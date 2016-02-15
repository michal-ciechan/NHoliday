# NHoliday
.NET Public Holiday Logic

# Usage

```
DateTime date = new Datetime(2016,1,1);

bool res = Japan.IsHoliday(date);
```
# GEneral Notes

- If a specific holiday is moved, this will return true for both the Original date ( e.g. 2016-01-01[original] and 2016-01-02[transferred] )

# Region Specific Notes

## Japan

- Correct as of Year 2000 onwards
- Max year to calculate is 2211. This is due to the Vernal Equinox DateTimes static data


