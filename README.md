# CryptoSoft

Logiciel externe de cryptage utilisé par le projet EasySave.

## Description

CryptoSoft est une application Console développée en C# et .NET 8.0.  
Le logiciel permet de chiffrer des fichiers à l'aide d'un algorithme XOR avec clé.

Le programme est conçu pour être appelé automatiquement par EasySave via `Process.Start()`.

---

## Fonctionnalités

- Chiffrement/déchiffrement de fichiers (XOR — même opération dans les deux sens)
- Gestion des erreurs avec codes de retour négatifs
- Compatible avec EasySave 2.0+

---

## Architecture du projet

```text
CryptoSoft
│
├── Program.cs
│
├── Models
│   └── CryptoResult.cs
│
├── Services
│   └── CryptoService.cs
│
└── Utils
    └── FileHelper.cs
```

---

## Technologies utilisées

- C# / .NET 8.0
- Console Application

---

## Utilisation

### Compilation

```bash
dotnet build
```

### Exécution

```bash
CryptoSoft.exe "<sourceFilePath>" "<destinationFilePath>"
```

---

## Codes de retour

| Code | Signification |
|------|---------------|
| `0`  | Succès |
| `-1` | Erreur (paramètres invalides ou exception) |

---

## Intégration avec EasySave

EasySave appelle `CryptoSoft.exe` via `Process.Start()` et lit le code de retour pour renseigner `EncryptionTimeMs` dans les logs.

---

## Auteur

Projet réalisé dans le cadre du module Génie Logiciel — CESI.
