// 4-10-2017

// How to pass query string parameter in ActionLink in MVC

// 4th parameter of Html.ActionLink can have any number of properties:

<%= Html.ActionLink("Check this", "Edit", "test", 
                     new { id = id, data=name }, new { style = "display:block" })%>

//These properties are inserted into URL based on routing, but if the property name cannot be matched into any route it is added as URL GET parameter.

//So if you have standard route {controller}/{action}/{id}, you will get the URL:

test/Edit/[id]?data=[name] 

//from the above code.