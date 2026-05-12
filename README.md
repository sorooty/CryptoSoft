# CryptoSoft

Logiciel externe de cryptage utilisé par le projet EasySave.

## Description

CryptoSoft est une application Console développée en C# et .NET.  
Le logiciel permet de chiffrer des fichiers à l’aide d’un algorithme XOR avec clé.

Le programme est conçu pour être appelé automatiquement par EasySave via `Process.Start()`.

---

## Fonctionnalités

- Chiffrement de fichiers
- Déchiffrement via le même algorithme XOR
- Gestion des erreurs
- Retour de codes d’exécution
- Compatible avec EasySave 2.0

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

- C#
- .NET
- Console Application

---

## Utilisation

### Compilation

```bash
dotnet build
```

### Exécution

```bash
dotnet run "<sourceFilePath>" "<destinationFilePath>"
```

Exemple :

```bash
dotnet run "D:\Test\test.txt" "D:\Test\encrypted.txt"
```

---

## Fonctionnement

Le logiciel :

1. Lit le fichier source
2. Applique un chiffrement XOR
3. Génère le fichier chiffré
4. Retourne un code d’exécution

---

## Codes de retour

| Code | Signification |
|------|------|
| 0 | Succès |
| -1 | Erreur de paramètres |
| -2 | Erreur durant le cryptage |

---

## Intégration avec EasySave

EasySave utilise `CryptoSoft.exe` via :

```csharp
Process.Start()
```

Le temps de cryptage est ensuite enregistré dans les logs du logiciel EasySave.

---

## Auteur

Projet réalisé dans le cadre du module Génie Logiciel — CESI.
