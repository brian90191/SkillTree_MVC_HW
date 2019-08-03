# [作業] ASP.NET MVC 實戰訓練營

課程網址: https://skilltree.my/events/2019/7/6/practical-asp-dot-net-mvc-essential

## 第一週作業要求
- [x] 必須使用 `Layout`

- [x] 下方列表部分建議分開，不要寫在同一頁 並且要有假資料（禁止寫死在 HTML）

- [x] 上方輸入的部分可以只是切版的結果不用實現功能。

- [x] 前方數字是流水號，不是 DB 的值

![image](https://github.com/brian90191/SkillTree_MVC_HW/blob/master/MVC_1_Template.png)

## 第二週作業要求
- [x] 請將記帳本呈現資料的部分改為真 DB

- [x] 可使用 `EF`, `ADO.NET`

- [x] 範例資料庫請使用 [HomeWorkDB 內的資料](https://github.com/brian90191/SkillTree_MVC_HW/blob/master/SkillTree_MVC_HW/App_Data/SkillTreeHomework.mdf) 

- [x] 不可改變第一天設計的 [ViewModel](https://github.com/brian90191/SkillTree_MVC_HW/blob/master/SkillTree_MVC_HW/Models/ViewModels/AccountViewModel.cs)

- [x] 建議練習

  * 實做 [Service](https://github.com/brian90191/SkillTree_MVC_HW/blob/master/SkillTree_MVC_HW/Service/AccountService.cs) 層

- [ ] 額外挑戰

  * `UnitOfWork`

  * `Repository`

## 第三週作業要求
- [x] 將記帳本的寫入功能完成

  * 必須真的寫進資料庫
  
- [x] 資料輸入驗證

  * 所有欄位均為必填
  
  * 「金額」只能輸入正整數
  
  * 「日期」不得大於今天
  
  * 「備註」最多輸入100個字元（TextArea）
  
- [x] 列表加入顏色變換

  * 類型的「支出」字樣顯現為紅色
  
  * 類型的「收入」字樣顯現為藍色

- [ ] 進階挑戰

  * 將記帳本的寫入功能改為 AJAX
