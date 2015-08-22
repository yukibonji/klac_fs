﻿module Util

    let inline konst x _ = x
    let inline konst_unit x () = x

    let inline curry2 f x y = f (x, y)
    let inline uncurry2 f (x, y) = f x y

    module List =
        ///最初の値を最初の状態として、左から畳み込む。
        ///Returns None iff given list is empty.
        let fold1 f = function
            | [] -> None
            | (x :: xs) -> Some <| List.fold f x xs

