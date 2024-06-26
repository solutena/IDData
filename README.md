# IDData

Json을 통해 파일로 저장 / 불러오기를 위한 데이터의 베이스입니다.

유니티에서 `Serializable` 데이터를 `null` 검사 할 때,

`null`이 아닌 `default`값 으로 초기화되어 `null` 검사가 정상적으로 동작하지 않는 문제가 있습니다.

이를 해결하기 위해서 객체를 생성할때 고유한 ID값(`GUID`)을 생성합니다.

`default`값으로 초기화 된다면 ID값(`GUID`)이 비어 있으므로 `null`로 취급하게 합니다.

`Serializable` 데이터를 사용할 때 이 클래스를 상속하여 사용하면

`null`검사를 정상적으로 처리할 수 있습니다.

## 예제

```
[Serializable]
public class Monster : IDData
{
	[SerializeField] int hp = 0;
	[SerializeField] int mp = 0;
}
```

Json으로 변환될 데이터에 IDData를 상속해줍니다.

```
if (this == null)
	return;
```
IDData가 상속된 데이터는

다음과 같이 null 검사를 할 수 있습니다.
