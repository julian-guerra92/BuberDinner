
## Auth

```
POST {{host}}/auth/register
```

### Register Request

```json
{
   "FirstName":"Julián",
   "LastName":"Rodríguez",
   "email":"julian@google.com",
   "password":"123456"
}
```

### Register Response

```js
200 ok
```

```json
{
   "id":"dbs8kjs-ajshj-bood9797",
   "FirstName":"Julián",
   "LastName":"Rodríguez",
   "email":"julian@google.com",
   "password":"123456",
   "token":"jdk544jd44a4a4j5...5454aj"
}
```

## Login
```
POST {{host}}/auth/login
```

```json
{
   "email":"julian@google.com",
   "password":"123456"
}
```
