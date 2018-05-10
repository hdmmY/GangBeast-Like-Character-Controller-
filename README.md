# GameJam2018

一个基于物理的抢球游戏。这是 2018 GlobalGameJam 上海站的作品。

游戏演示视频：[上海 Unity站 展示环节](https://www.bilibili.com/video/av20119830/?p=8)

游戏下载页面：[A Serious Ball Game](https://globalgamejam.org/2018/games/serious-ball-game)

不过现在这个工程文件里只剩下人物控制器了。

### 人物控制器使用说明

键盘：

+ WASD 控制移动。
+ 空格键 跳跃。
+ 鼠标右键点击拾取物品，鼠标左键点击丢弃物品

手柄(以 XBOX 为例，PS4 也差不多)：

+ 左摇杆控制移动。
+ A 键跳跃。
+ X 键拾取物品，B 键丢弃物品。

拾取操作说明：

按住拾取键，Player 的手会向前伸尝试拾取物体，若拾取到了物体，则拾取结束；否则，最多保持拾取动作 3s，之后有 1s 的冷却时间（无法拾取）。

### 制作可拾取的物品

1. 在场景中导入 3D 模型，添加相应的碰撞体。碰撞体可以是这个 3D 模型的子物体。
2. 为 3D 模型添加 Rigidbody 和 Item Info 组件。
3. 设置这个物体的 breakForce 和 breakTorqu。 
5. 完成！