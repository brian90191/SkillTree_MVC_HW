$(function () {
    $('#CreateTime_DP').datepicker({
        format: "yyyy-mm-dd",
        autoclose: true,
        endDate: "today",
        clearBtn: true,
        calendarWeeks: true,
        todayHighlight: true,
        language: 'zh-TW'
    });
});