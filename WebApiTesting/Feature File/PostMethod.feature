Feature: PostMethod
	
Scenario: posting data using POST method
	When user sends the data to the server as given
		| key    | value  |
		| name   | Adarsh |
		| salary | 26000  |
		| age    | 23     |
	Then user validate the status and data