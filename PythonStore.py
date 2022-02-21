#!/usr/bin/env python3
# CSCI A125
# Group 5 Project
import locale as lc
import csv
STORE_FILE = "store_file.csv"
CART_FILE = "cart_file.csv"

# Menu to print
def print_menu():
	
    print("Welcome to the Web Store!")
    print("-" * 25)
    print("1 - Store")
    print("2 - Cart")
    print("3 - Exit")
    print("-" * 25)
	
# Function to read STORE_FILE and store as storeList
def read_file():
	storeList = []
	try:
		with open(STORE_FILE, newline = "") as file:
			reader = csv.reader(file)
			for row in reader:
				storeList.append(row)
		return storeList
	except FileNotFoundError:
		print("Could not find " + STORE_FILE + " file.")
		main()
	except Exception as e:
		print(type(e), e)
		main()

# Function to write storeList to file
def write_file(storeList):
	try:
		with open(STORE_FILE, "w", newline = "") as file:
			writer = csv.writer(file)
			writer.writerows(storeList)
	except Exception as e:
		print(type(e), e)
		main()
		
# Function to list the contents of storeList
def list_items(storeList):
	for i in range(0, len(storeList)):
		storeList1 = storeList[i]
		print(storeList1[0] + "\t\t " + lc.currency(int(storeList1[1]), grouping=True)) # Print storeList1
		
# Function to add item to storeList
def add_item(storeList):
	while True:
		item_name = input("Enter Item Name: ")
		item_check = item_name.isdigit() # Checks if name is digit. Better way to do this?
		if item_check == True:
			print("Please Enter a Correct Item!")
		else:
			item_price = input("Enter Item Price: ")
			price_check = item_price.isdigit() # Checks if price is digit. Better way to do this?
			if price_check == False:
				print("Please enter a Correct Price:")
			else:
				item = []
				item.append(item_name)
				item.append(item_price)
				storeList.append(item) # Appends the different lists
				write_file(storeList) # Save to file.
				print(item_name + " was added at " + lc.currency(int(item_price), grouping=True)) # Print item_name
				break
		
# Function to remove items fro storeList	
def remove_item(storeList):   
	while True:
		read_file()
		choice = input("Enter Position of Number ")
		choiceCheck = choice.isdigit()
		if choiceCheck == True:
			storeList.pop(int(choice) - 1) # Removes item from storeList
			print("Item in position "  + choice + " was deleted")
			write_file(storeList) # Save to file
			break
		else:
			print("Please Enter a Number!")

# Function to display items in the for sale
def purchase_item(storeList):
	cart = []
	while True:
		print("For Sale")
		print()
		list_items(storeList)
		choice = int(input("Please Select an Item: "))
		cart.append(storeList[choice-1]) # Add item to cart list
		storeList.pop(choice-1) # Remove item from storeList
		write_file(storeList) # Save to file
		with open(CART_FILE, "w", newline = "") as file: # Write cart list to file
			writer = csv.writer(file)
			writer.writerows(cart)
		for i in range(0, len(cart)): # Print out cart list
			cart1 = cart[i]
			print("You Selected: " + cart1[0] + "\t\t " + lc.currency(cart1[1]), grouping=True) 
		
# Function to display options for the store	
def store(storeList):
	while True:
		print("Welcome to the Store!")
		print("1 - List Items For Sale")
		print("2 - Remove Item From Sale")
		print("3 - Add item For Sale")
		print("4 - Purchase Items")
		print("5 - Exit")
		store_input = input("Please Pick a Menu: ")
		if store_input == "1":
			list_items(storeList)
			break
		elif store_input == "2":
			remove_item(storeList)
			break
		elif store_input == "3":
			add_item(storeList)
			break
		elif store_input == "4":
			purchase_item(storeList)
			break
		elif store_input == "5":
			exit()
			break
		else:
			print("Please Enter a Correct Menu!")
			
# Shopping cart function
def cart(cart):
	cart = []
	with open(CART_FILE, newline = "") as file: # Open CART_FILE for reading
		reader = csv.reader(file)
		for row in reader: # Append cart list with data from CART_FILE
			cart.append(row)
	print("Your Cart")
	for i in range(0, len(cart)): # Print out contents of cart
		cart1 = cart[i]
		print(cart1[0] + "\t\t " + lc.currency(int(cart1[1]), grouping=True))

# Main function
def main():
	storeList = read_file()
	lc.setlocale(lc.LC_ALL, "us") # Adds currency
	while True:
		print_menu()
		user_input = input("Please Pick a Menu: ")
		if user_input == "1":
			store(storeList)
			
		elif user_input == "2":
			cart(cart)
		
		elif user_input == "3":
			exit()
			break
		else:
			print("Please Enter a Correct Menu!")

if __name__ == "__main__":
    main()
