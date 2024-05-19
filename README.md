# Tween Manager (MyTweener) **No Plugin For This Part**

This project provides a simple and flexible way to handle tween animations in Unity, following SOLID principles. The system supports various types of transformations including scaling, rotating, moving, and color changing for both 3D objects and UI elements.

## Features

- **ScaleAction**: Tween the scale of a `Transform`.
- **RotateAction**: Tween the rotation of a `Transform`.
- **MoveAction**: Tween the position of a `Transform`.
- **ColorAction**: Tween the color of a `SpriteRenderer`.
- **UIColorAction**: Tween the color of a `UI.Image`.

## Installation

1. Clone or download the repository.
2. Add the scripts to your Unity project.

## Usage

### ScaleAction

```csharp
public class ScaleAction : ITweenAction
{
    private readonly Vector3 _endValue;
    private readonly float _duration;

    public ScaleAction(Vector3 endValue, float duration = 1f)
    {
        _endValue = endValue;
        _duration = duration;
    }

    public IEnumerator Apply(Transform target, MonoBehaviour behaviour, System.Action completeAction = null)
    {
        Vector3 startValue = target.localScale;
        float elapsed = 0f;

        while (elapsed < _duration)
        {
            target.localScale = Vector3.Lerp(startValue, _endValue, elapsed / _duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        target.localScale = _endValue;
        completeAction?.Invoke();
    }
}
```

# CTween Animation Manager (Static-Extention of Transform)

## Overview

`CTween` is a flexible and extensible animation manager for Unity that utilizes the DOTween library to handle various transformations and animations on Unity objects. It adheres to the SOLID principles, ensuring maintainability and scalability.

## Features

- Scale Animation
- Rotate Animation
- Move Animation
- Color Animation (for UI Image components)
- Fade Animation (for UI Image components)

## Installation

1. Ensure you have DOTween installed in your Unity project.
2. Copy the provided script files into your project.

## Usage

### Setting Up Tween Actions

Each type of tween action is encapsulated in its own class implementing the `ITweenAction` interface. This allows for clear and maintainable code.

### ScaleAction

```csharp
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace ShinyPi.Utility.Anim
{
    public class ScaleAction : ITweenAction
    {
        private readonly Vector3 _endValue;
        private readonly float _tweenTime;
        private readonly Ease _ease;

        public ScaleAction(Vector3 endValue, float tweenTime = 0.5f, Ease ease = Ease.InOutExpo)
        {
            _endValue = endValue;
            _tweenTime = tweenTime;
            _ease = ease;
        }

        public Tweener Apply(Transform t, UnityAction completeAction = null)
        {
            return t.DOScale(_endValue, _tweenTime)
                .SetEase(_ease)
                .OnComplete(() => completeAction?.Invoke());
        }
    }
}
```
# Tweening Manager (MonoBehaviour)

This repository contains a Tweening Manager implemented in Unity using the DOTween plugin. The manager is designed to adhere to SOLID principles, making it modular, extensible, and maintainable.

## Features

- **Single Responsibility Principle (SRP)**: Each class has one responsibility.
- **Open/Closed Principle (OCP)**: Classes are open for extension but closed for modification.
- **Liskov Substitution Principle (LSP)**: Subtypes can be substituted for their base types.
- **Interface Segregation Principle (ISP)**: Client-specific interfaces are used.
- **Dependency Inversion Principle (DIP)**: Depend on abstractions, not concretions.
- **Animation Toggle**: Ability to enable or disable animations globally.

## Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/Sadeqsoli/Tweening.git
    ```

2. Open the project in Unity.

3. Install the [DOTween plugin](https://dotween.demigiant.com/getstarted.php) if not already installed.

## Usage

1. **Create a TweenManager instance**:
    ```csharp
    TweenManager tweenManager = new TweenManager(animate);
    ```

2. **Add Tween Actions**:
    ```csharp
    tweenManager.AddAction(new ScaleAction(target, new Vector3(1, 1, 1), 1f, Ease.InOutExpo, () => Debug.Log("Scale Complete"), false));
    ```

3. **Execute Actions**:
    ```csharp
    tweenManager.ExecuteActions();
    ```

## Example

```csharp
using UnityEngine;

public class Example : MonoBehaviour
{
    public Transform target;
    public bool animate;

    void Start()
    {
        TweenManager tweenManager = new TweenManager(animate);

        tweenManager.AddAction(new ScaleAction(target, new Vector3(1, 1, 1), 1f, Ease.InOutExpo, () => Debug.Log("Scale Complete"), false));
        
        tweenManager.ExecuteActions();
    }
}
```
## Contributing
Contributions are welcome! Please create a pull request or open an issue to discuss your changes.

## License
This project is licensed under the MIT License - see the LICENSE file for details.