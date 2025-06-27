# Caffeine ☕

Are you tired of your Windows PC dozing off when you need it most? Does your ~~status on Teams, Slack, or Webex keep turning "away" while you're just deep in thought or~~ PC go to sleep when grabbing another coffee?? **Caffeine** is here to keep your PC wide awake and your status forever green!

Caffeine is a simple yet effective script that prevents your Windows machine from going to sleep. No more fiddling with power settings or jiggling your mouse every few minutes.

---

## How It Works

Caffeine's secret is delightfully simple: it **simulates a keyboard key press every minute.** Don't worry, it's not pressing `Shift` or `Space` and messing up your work. Instead, it presses an **"unassigned" virtual key** that Windows recognizes as activity, but doesn't actually do anything in your applications. This clever trick keeps your system active, preventing it from entering sleep mode due to inactivity.

---

## Versions Available

We've got Caffeine brewing in a few different flavors to suit your preference:

### PowerShell Version (Recommended)

This is the **recommended** version for most Windows users. It's easy to run, integrates well with the system, and doesn't require any extra installations if you have PowerShell (which you do!).

### Python Version (Recommended)

If you're a Python enthusiast, this version is for you! It offers cross-platform potential (though currently focused on Windows) and is easy to modify if you want to tweak its behavior. You'll need a Python installation to run this.

### Visual Basic.NET Version (Historical - Use with Caution!)

For historical reasons, the original Visual Basic .NET version is still included. However, we **strongly advise against using it.** This code is likely very old, probably "spaghetti code," and potentially quite terrible to maintain or even run safely. It's more of a relic than a recommendation!

---

## Installation & Usage

### PowerShell

1.  **Download:** Grab the `caffeine.ps1` file from this repository.
2.  **Run:** Open PowerShell and navigate to the directory where you saved the file. Then run:
    ```powershell
    .\Caffeine.ps1
    ```
    *You might need to adjust your PowerShell execution policy if you encounter errors. You can temporarily set it with `Set-ExecutionPolicy RemoteSigned -Scope CurrentUser`.*

### Python

1.  **Prerequisites:** Make sure you have Python installed.
2.  **Download:** Get the `caffeine.py` file.
3.  **Install dependencies:** You might need `pywin32` for Windows-specific keypresses. Install it via pip:
    ```bash
    pip install pywin32
    ```
4.  **Run:** Open Command Prompt or PowerShell, navigate to the file's directory, and run:
    ```bash
    python caffeine.py
    ```

---

## Contributing

Got an idea to make Caffeine even more potent? Found a bug? Feel free to open an issue or submit a pull request!

---

## License

```
Do No Harm License

Preamble
Most software today is developed with little to no thought of how it will be used, or the consequences for our society and planet.
As software developers, we engineer the infrastructure of the 21st century. We recognise that our infrastructure has great power to shape the world and the lives of those we share it with, and we choose to consciously take responsibility for the social and environmental impacts of what we build.
We envisage a world free from injustice, inequality, and the reckless destruction of lives and our planet. We reject slavery in all its forms, whether by force, indebtedness, or by algorithms that hack human vulnerabilities. We seek a world where humankind is at peace with our neighbours, nature, and ourselves. We want our work to enrich the physical, mental and spiritual wellbeing of all society.
We build software to further this vision of a just world, or at the very least, to not put that vision further from reach.

Terms
*Copyright* (c) 20XX cttynul. All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
1. Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
2. Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
3. Neither the name of the copyright holder nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
4. This software must not be used by any organisation, website, product or service that:
   a) lobbies for, promotes, or derives a majority of income from actions that support or contribute to:
      * sex trafficking
      * human trafficking
      * slavery
      * indentured servitude
      * gambling
      * tobacco
      * adversely addictive behaviours
      * nuclear energy
      * warfare
      * weapons manufacturing
      * war crimes
      * violence (except when required to protect public safety)
      * burning of forests
      * deforestation
      * hate speech or discrimination based on age, gender, gender identity, race, sexuality, religion, nationality

   b) lobbies against, or derives a majority of income from actions that discourage or frustrate:
      * peace
      * access to the rights set out in the Universal Declaration of Human Rights and the Convention on the Rights of the Child
      * peaceful assembly and association (including worker associations)
      * a safe environment or action to curtail the use of fossil fuels or prevent climate change
      * democratic processes

5. All redistribution of source code or binary form, including any modifications must be under these terms. You must inform recipients that the code is governed by these conditions, and how they can obtain a copy of this license. You may not attempt to alter the conditions of who may/may not use this software.

We define:
- Forests to be 0.5 or more hectares of trees that were either planted more than 50 years ago or were not planted by humans or human made equipment.
- Deforestation to be the clearing, burning or destruction of 0.5 or more hectares of forests within a 1 year period.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

Attribution
Do No Harm License available at https://github.com/raisely/NoHarm
```
