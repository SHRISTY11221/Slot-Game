# Slot Machine Game

## Game Overview

This project is a simple Slot Machine Game developed in Unity as part of a technical assignment. The game simulates a classic 3-reel slot machine where players spin the reels and win when all middle-row symbols match.

### Features

* 3-Reel Slot Machine
* Random Symbol Generation
* Weighted RNG System
* Win Detection Based on Matching Symbols
* Different Payout Values for Different Symbols
* Smooth Reel Spinning Animation
* Main Menu UI
* Exit Confirmation Popup
* Back to Main Menu Functionality
* Responsive UI for WebGL

### Symbols & Payouts

| Symbol | Payout |
| ------ | ------ |
| Cherry | 10     |
| Bell   | 20     |
| BAR    | 50     |
| Seven  | 100    |

A win occurs when all three middle-row symbols are identical.

---



## Thought Process / Approach

The primary goal was to create a simple, maintainable, and expandable slot machine system while keeping the codebase clean and easy to understand.

### Design Approach

1. Separate the slot machine logic into:

   * Reel Controller
   * Slot Machine Controller
   * Menu Manager

2. Use Object-Oriented Programming principles to keep responsibilities isolated.

3. Implement a weighted randomization system to simulate realistic slot machine odds while keeping the logic straightforward.

4. Keep the UI structure simple and modular to allow future additions such as coin systems, audio, and bonus rounds.

5. Focus on readability and maintainability by using descriptive variable names and separating gameplay, UI, and menu logic into different scripts.

The project prioritizes simplicity, clean architecture, and scalability while fulfilling all assignment requirements.
