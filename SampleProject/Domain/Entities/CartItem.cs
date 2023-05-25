﻿namespace SampleProject.Domain.Entities;

public partial record CartItem
{
    public Identifier Id { get; init; }
    public Identifier CartId { get; init; }
    public Identifier ProductId { get; init; }
    public Amount Amount { get; init; }

    public CartItem()
    {
        Id = new Identifier();
        CartId = new Identifier();
        ProductId = new Identifier();
        Amount = new Amount();
    }

    public static Entity<CartItem> Create(string idValue, string cartId, string productIdValue, int amountValue, string amountCurrency)
    {
        return Entity<CartItem>.Valid(new CartItem())
            .SetId(idValue)
            .SetCartId(cartId)
            .SetProductId(productIdValue)
            .SetAmount(amountValue, amountCurrency);
    }
}

// Can be autogenerated with Grenat.Functional.DDD.Generators: 
// https://github.com/BastienFoucher/Grenat.Functional.DDD.Generators
public static partial class CartItemSetters
{
    public static Entity<CartItem> SetId(this Entity<CartItem> cartItem, String value)
    {
        return cartItem.SetId(Identifier.Create(value));
    }

    public static Entity<CartItem> SetId(this Entity<CartItem> cartItem, ValueObject<Identifier> id)
    {
        return cartItem.SetValueObject(id, static (cartItem, id) => cartItem with { Id = id });
    }

    public static Entity<CartItem> SetCartId(this Entity<CartItem> cartItem, String value)
    {
        return cartItem.SetCartId(Identifier.Create(value));
    }

    public static Entity<CartItem> SetCartId(this Entity<CartItem> cartItem, ValueObject<Identifier> id)
    {
        return cartItem.SetValueObject(id, static (cartItem, id) => cartItem with { CartId = id });
    }

    public static Entity<CartItem> SetProductId(this Entity<CartItem> cartItem, String value)
    {
        return cartItem.SetProductId(Identifier.Create(value));
    }

    public static Entity<CartItem> SetProductId(this Entity<CartItem> cartItem, ValueObject<Identifier> productId)
    {
        return cartItem.SetValueObject(productId, static (cartItem, productId) => cartItem with { ProductId = productId });
    }

    public static Entity<CartItem> SetAmount(this Entity<CartItem> cartItem, Int32 value, String currency)
    {
        return cartItem.SetAmount(Amount.Create(value, currency));
    }

    public static Entity<CartItem> SetAmount(this Entity<CartItem> cartItem, ValueObject<Amount> amount)
    {
        return cartItem.SetValueObject(amount, static (cartItem, amount) => cartItem with { Amount = amount });
    }

}

// Can be autogenerated with Grenat.Functional.DDD.Generators: 
// https://github.com/BastienFoucher/Grenat.Functional.DDD.Generators
public partial class CartItemBuilder
{
    private string _idValue;

    public CartItemBuilder WithId(string idValue)
    {
        _idValue = idValue;
        return this;
    }

    private string _cartIdValue;

    public CartItemBuilder WithCartId(string cartIdValue)
    {
        _cartIdValue = cartIdValue;
        return this;
    }

    private string _productId;

    public CartItemBuilder WithProductId(string productId)
    {
        _productId = productId;
        return this;
    }

    private int _amountValue;
    private string _amountCurrency;

    public CartItemBuilder WithAmount(int amountValue, string amountCurrency = "EUR")
    {
        _amountValue = amountValue;
        _amountCurrency = amountCurrency;
        return this;
    }

    public CartItemBuilder()
    {
        _amountCurrency = string.Empty;
        _cartIdValue = string.Empty;
        _amountValue = 0;
        _productId = string.Empty;
        _idValue = string.Empty;
    }

    public Entity<CartItem> Build() => CartItem.Create(_idValue, _cartIdValue, _productId, _amountValue, _amountCurrency);

}


