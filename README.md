# RedisSampleApp

In order to understand how is caching data using Redis and to use this logic in a bigger project, I am creating a sample app.

1-)For setting up Redis in Docker. This code which is located below, is going to image the Redis.
![WhatsApp Image 2021-05-27 at 01 57 25](https://user-images.githubusercontent.com/73940626/119746028-c040b900-be8f-11eb-936d-f7012bbf0a5b.jpeg)

2-)Here you can see the my Redis data.
![WhatsApp Image 2021-05-27 at 01 58 50](https://user-images.githubusercontent.com/73940626/119746120-fc741980-be8f-11eb-80d1-b8b1dfb0bbbd.jpeg)

3-)Now I am talking directly to the cache, to the database
![WhatsApp Image 2021-05-27 at 02 00 43](https://user-images.githubusercontent.com/73940626/119746175-23325000-be90-11eb-9f87-a4ca6541191c.jpeg)

4-)It response me that it's awake and working.
![WhatsApp Image 2021-05-27 at 02 01 10](https://user-images.githubusercontent.com/73940626/119746230-45c46900-be90-11eb-8a68-7dd5c5863a85.jpeg)

5-)This is what we get when we run our app
![image](https://user-images.githubusercontent.com/73940626/119743573-7903f980-be8a-11eb-9fb5-98b2c6fc8657.png)

6-)This is the Fetch data side in our app
![image](https://user-images.githubusercontent.com/73940626/119743631-9769f500-be8a-11eb-9723-17407ad34014.png)

7-)When we click on Load Forecast button, it showes us to the "loading...".
![image](https://user-images.githubusercontent.com/73940626/119743749-db5cfa00-be8a-11eb-80a5-e7ae2ca72b7b.png)

8-)And then we get our requests
![WhatsApp Image 2021-05-27 at 01 31 47](https://user-images.githubusercontent.com/73940626/119744255-e6645a00-be8b-11eb-9ff7-447668687a71.jpeg)

9-)When we click on Load Forecast button second time we are caching our data. 
![WhatsApp Image 2021-05-27 at 01 32 02](https://user-images.githubusercontent.com/73940626/119744323-0ac03680-be8c-11eb-99d9-fcf0cfb144a7.jpeg)

10-)Let's go to the docker and see what we cache to the database.There is a key which given us right after the clicking on Load Forecast button.
![WhatsApp Image 2021-05-27 at 01 32 29](https://user-images.githubusercontent.com/73940626/119744392-38a57b00-be8c-11eb-90ce-bf9c92c2f999.jpeg)

11-)We type "hgetall" and then our key which is located in our database, it showes us to what this container contains in it. 
![WhatsApp Image 2021-05-27 at 01 33 52](https://user-images.githubusercontent.com/73940626/119744538-85895180-be8c-11eb-8731-93fbf58d4ea0.jpeg)

12-)It's going to disappear after sometime.
![WhatsApp Image 2021-05-27 at 01 35 32](https://user-images.githubusercontent.com/73940626/119744711-dac56300-be8c-11eb-8720-76191303ec82.jpeg)

13-)This is how we can exit from Redis that typing 2 times "exit" in a row. 
![WhatsApp Image 2021-05-27 at 01 45 23](https://user-images.githubusercontent.com/73940626/119745276-17de2500-be8e-11eb-9cfc-a4f48d66a16b.jpeg)

14-)This is how we can stop and remove existing repository.
![WhatsApp Image 2021-05-27 at 01 48 27](https://user-images.githubusercontent.com/73940626/119745341-36dcb700-be8e-11eb-9b2f-6857506139cb.jpeg)
