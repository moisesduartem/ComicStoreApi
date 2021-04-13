# Autenticação

## Realizar Login 
- `POST /v1/account/login`

### Exemplo de JSON da requisição:
```
{
  "email": "captainamerica@gmail.com",
  "password": "123456"
}
```

## Realizar cadastro 
- `POST /v1/account/register`

### Exemplo de JSON da requisição:
```
{
	"name": "Tony Stark",
	"email": "stark@gmail.com",
	"username": "tony.stark",
	"password": "123456"
}
```

# Usuários

## Listar usuários cadastrados
- `GET /v1/users`


# Compras

## Realizar compra de quadrinho
- `POST /v1/users/purchases`

### Exemplo de JSON da requisição:
```
{
	"comicId": 1332,
	"price": 9.99
}
```

## Listar compras do usuário logado
- `GET /v1/users/purchases`


---

**Autor**: Moisés Mariano