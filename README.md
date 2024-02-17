**Welcome to ChangesInRates API.**

This API is designed to allow you to observe the difference in currency exchange rates between the provided date and one day prior. 
The base currency is the Lithuanian Litas, so the dates you can provide are only before December 21, 2014.

This API was created using .NET Core and a PostgreSQL database.

Instructions on how to run it:

1. First, run the DbSetup project and run migrations to create a database.
2. Second, run Web project and have fun examining changes in currency exchange rates. 