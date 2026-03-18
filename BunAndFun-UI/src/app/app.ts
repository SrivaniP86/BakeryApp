import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductService, Product } from './services/product';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule],
  templateUrl:  './app.html',
  styleUrl: './app.scss'
})
export class AppComponent implements OnInit {
  products: Product[] = [];
  cart: Product[] = [];
  cartTotal: number = 0;
  showToast: boolean = false;
  currentView: 'shop' | 'cart' = 'shop';


  constructor(private productService: ProductService) {}

  ngOnInit() {
    this.productService.getProducts().subscribe({
      next: (data) => this.products = data,
      error: (err) => console.error('API Error:', err)
    });
  }

 addToCart(product: Product) {
    this.cart.push(product);
    this.calculateTotal();
    this.showToast = true;
    setTimeout(() => this.showToast = false, 2000);
  }

  calculateTotal() {
    this.cartTotal = this.cart.reduce((sum, item) => sum + item.price, 0);
  }



 removeItem(index: number) {
    this.cart.splice(index, 1);
    this.calculateTotal();
  }
  
  proceedToPayment() {
    alert(`Redirecting to payment gateway for ${this.cartTotal.toLocaleString('en-US', { style: 'currency', currency: 'USD' })}...`);
    // here it should be integrated to stripe or paypal - yet to be done (not finished)
  }
}