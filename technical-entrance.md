# Welcome to Hoozing's technical entrance

### There are 3 questions, please take a deep breath, keep calm and answer the questions.

### Submission Guideline:
- Fork (copy) this repository.
- Clone the forked repository in your local computer.
- In the submission folder, create file(s) to store your answers.
- Commit your answers.
- Push the commit(s) to your public repositry in github.
- Email us the url of your github repository so that we can view your answers.

##  1. Write an algorithm to find missing number

####  Given an array of size n-1 and given that there are numbers from 1 to n with one missing, write an function to find the missing number

- For example:
 *Input:* `[2,3,1,4,6,9,7,8,10,7]`
 *Output:* `5`

## 2. Refactoring the following method

    public void Register(UserModel user) {
	    try {
		    MailMessage message =  new  MailMessage();
		    message.To.Add(user.Email);
		    message.Subject = "Register";
		    message.From = new  System.Net.Mail.MailAddress("admin@hotmail.com");
		    message.Body = "Thank you for your register";
		    SmtpClient smtp = new SmtpClient();
		    smtp.Host = "smtp.gmail.com";
		    smtp.Send(message);
		    
	    }  catch(Exception) {
	    }
    
	    bool validate = true;
	    string errorMessage = "";
	    if (String.IsNullOrEmpty(user.UserName)) {
		    errorMessage += "You must specify a username."'
		    validate = false;
	    }
	    
	    if (String.IsNullOrEmpty(user.Email)) {
		    errorMessage += "You must specify an email address.";
		    validate = false;
	    }
	    
	    else if(!Regex.IsMatch(email,"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$.", RegexOptions.IgnoreCase)) {
		    errorMessage += "You must specify a valid email address.";
		    validate = false;
	    }
    
	    bool isExisted =  false;
	    var existedUser = _userService.GetUserByUsername(user.Username);
    
	    if  (existedUser != null) {
		    isExisted = true;
	    }  else {
		    isExisted = false;
	    }
    
	    if  (isExisted) {
		    errorMessage += "User with that username and/or email already exists.";
	    }
    
	    if  (user.Password == null || user.Password.Length < 6) {
		    errorMessage += "You must specify a password of {0} or more characters.",  6);
	    }
    
	    if  (!String.Equals(user.Password, user.ConfirmPassword, StringComparison.Ordinal)) {
		    errorMessage += "The new password and confirmation password do not match.";
	    }
    
	    if  (validate) {
		    Regex RgxUrl = new  Regex("[^a-z0-9]");
		    var isContainsSpecialCharacters = RgxUrl.IsMatch(user.Username);
		    if  (!isContainsSpecialCharacters) {
			    _userService.SaveUser(user);
		    }
	    }
	    
    }


## 3. Write script in SQL Server

####  There are 3 tables as below, write an SQL query to retrieve the best selling product of last month. 
####  The accepted query should have 2 fields: `Product Name`, `NumberOfSellingProducts`


> Order Table

| Field Name | Data Type |
|--|--|
| Id | int |
| Date | DateTime |
| Total| double|

> Order Detail Table

| Field Name | Data Type |
|--|--|
| Id | int |
| Order Id | int|
| Quality| int |
| Price| double|
| ProductId| int |
| Amount| double|

> Product Table

| Field Name | Data Type |
|--|--|
| Id | int |
| Name | string|
