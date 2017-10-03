Preparing GIT
-------------

Add to `~/.gitconfig`

    [merge]
    tool = unityyamlmerge

    [mergetool "unityyamlmerge"]
    trustExitCode = false
    cmd = 'C:\Program Files\Unity\Editor\Data\Tools\UnityYAMLMerge.exe' merge -p "$BASE" "$REMOTE" "$LOCAL" "$MERGED"

And make sure git-lfs is installed: https://git-lfs.github.com
..and then run `git lfs install`
