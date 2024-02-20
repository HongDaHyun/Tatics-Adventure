# Tatics Adventure

**[Alpha 1.2]**<br/>
- 스테이지별 몬스터 해금 활성화<br/>
<pre>	Grass -> Goblin, Slime, Mushroom</pre><br/>
<pre>	Cave -> Skeleton, Ghost, Poison Soul</pre><br/>
<pre>	Swarm -> Fire Soul, Ice Soul, Monkey</pre>
- Empty Card 새로 등장<br/>
- Card 이미지 스프라이트 추가 (빈카드, 보스카드)<br/>
- 설명 추출 로직 추가 (Chest, Empty에 적용) (Player 추가 예정)<br/>

**[Alpha 1.2.1]**<br/>
<img src="https://github.com/HongDaHyun/Tactics-Adventure/assets/101586627/286abc1d-665e-4224-80f8-344b3349d3a2" width="540" alt="Alpha 1.2.1">
<br/>
- 스킬 버튼 추가<br/>
- 스킬 아이콘 스프라이트 Import<br/>
- Canvas 추가<br/>
- 무기 데미지 산정 공식 재정의<br/>
- 카드 애니메이션(닷트윈) 추가 (스폰, 삭제, 데미지)<br/>

**[Alpha 1.2.2]**<br/>
<img src="https://github.com/HongDaHyun/Tactics-Adventure/assets/101586627/1b58c2ea-4ea6-4e22-98cd-25b6fac02c1a" width="540" alt="Alpha 1.2.2">
<br/>
- Knight 스킬 추가<br/>
<pre>	Active : 무기 공격력 1 증가, 무기가 없다면 공격력 1인 롱소드 장착</pre><br/>
<pre>	Passive : 방어도 1 증가</pre>
- 스킬 UI 쿨타임 표시<br/>
- 턴 알고리즘 최적화<br/>
- UIManager, BtnManager 추가<br/>
- 터치 이벤트 알고리즘 재정의<br/>
- 돈 UI 추가<br/>
- 데미지 받았을 때 텍스트 나오지 않던 버그들 수정<br/>
- MP, Defend UI와 알고리즘 추가<br/>
- Player 무기 장착 알고리즘 변경<br/>

**[Alpha 1.2.3]**<br/>
<img src="https://github.com/HongDaHyun/Tactics-Adventure/assets/101586627/e30bb835-1f3d-4059-829b-8eca463e647f" width="540" alt="Alpha 1.2.3">
<br/>
- Player 애니메이션 추가 (Idle, Walk, Damaged, Atk, Die, Interaction)<br/>
- Monster 애니메이션 추가 (Idle, Walk, Damaged, Atk, Die)<br/>
- 딜레이 로직 변경 (0.1f -> 애니메이션 종료 시점)<br/>
- 중복된 이미지 통합<br/>
- 카드 작동 관련 전부 코루틴화<br/>
- 카드 작동 중 액티브 스킬 비활성화<br/>

**[Alpha 1.2.4]**<br/>
<img src="https://github.com/HongDaHyun/Tactics-Adventure/assets/101586627/e3c7ed1d-1b97-4cec-b4f3-2c8016826d36" width="540" alt="Alpha 1.2.4">
<br/>
- 손 이미지 추가 (활성화, 비활성화)<br/>
- 손 시스템 추가<br/>
<pre>	이제 무기를 최대 2개 저장할 수 있습니다.</pre><br/>
<pre>	손 UI가 플레이어의 클릭에 반응합니다.</pre><br/>
<pre>	터치 동작 수행중이 아니라면 언제든지 손을 변경할 수 있습니다.</pre>
- UI 재배치<br/>