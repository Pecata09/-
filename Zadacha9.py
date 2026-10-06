EURO_RATE = 1.94  
veg_price = float(input())
fruit_price = float(input())
veg_kg = int(input())
fruit_kg = int(input())
total_bgn = veg_price * veg_kg + fruit_price * fruit_kg
total_eur = total_bgn / EURO_RATE
print(f"{total_eur:.2f}")