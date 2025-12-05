Demo Recording Is It LOADING 

ase) PS C:\Users\dexte> conda create -n mlagentsRec python=3.10.12 -y
Collecting package metadata (current_repodata.json): done
Solving environment: unsuccessful attempt using repodata from current_repodata.json, retrying with next repodata source.
Collecting package metadata (repodata.json): done
Solving environment: done


==> WARNING: A newer version of conda exists. <==
  current version: 23.7.4
  latest version: 25.11.0

Please update conda by running

    $ conda update -n base -c defaults conda

Or to minimize the number of packages updated during conda update use

     conda install conda=25.11.0



## Package Plan ##

  environment location: C:\Users\dexte\anaconda3\envs\mlagentsRec

  added / updated specs:
    - python=3.10.12


The following packages will be downloaded:

    package                    |            build
    ---------------------------|-----------------
    ca-certificates-2025.12.2  |       haa95532_0         125 KB
    libzlib-1.3.1              |       h02ab6af_0          64 KB
    openssl-3.0.18             |       h543e019_0         6.8 MB
    pip-25.3                   |     pyhc872135_0         1.1 MB
    setuptools-80.9.0          |  py310haa95532_0         1.4 MB
    sqlite-3.51.0              |       hda9a48d_0         917 KB
    tk-8.6.15                  |       hf199647_0         3.5 MB
    zlib-1.3.1                 |       h02ab6af_0         113 KB
    ------------------------------------------------------------
                                           Total:        14.1 MB

The following NEW packages will be INSTALLED:

  bzip2              pkgs/main/win-64::bzip2-1.0.8-h2bbff1b_6
  ca-certificates    pkgs/main/win-64::ca-certificates-2025.12.2-haa95532_0
  libffi             pkgs/main/win-64::libffi-3.4.4-hd77b12b_1
  libzlib            pkgs/main/win-64::libzlib-1.3.1-h02ab6af_0
  openssl            pkgs/main/win-64::openssl-3.0.18-h543e019_0
  pip                pkgs/main/noarch::pip-25.3-pyhc872135_0
  python             pkgs/main/win-64::python-3.10.12-he1021f5_0
  setuptools         pkgs/main/win-64::setuptools-80.9.0-py310haa95532_0
  sqlite             pkgs/main/win-64::sqlite-3.51.0-hda9a48d_0
  tk                 pkgs/main/win-64::tk-8.6.15-hf199647_0
  tzdata             pkgs/main/noarch::tzdata-2025b-h04d1e81_0
  ucrt               pkgs/main/win-64::ucrt-10.0.22621.0-haa95532_0
  vc                 pkgs/main/win-64::vc-14.3-h2df5915_10
  vc14_runtime       pkgs/main/win-64::vc14_runtime-14.44.35208-h4927774_10
  vs2015_runtime     pkgs/main/win-64::vs2015_runtime-14.44.35208-ha6b5a95_10
  wheel              pkgs/main/win-64::wheel-0.45.1-py310haa95532_0
  xz                 pkgs/main/win-64::xz-5.6.4-h4754444_1
  zlib               pkgs/main/win-64::zlib-1.3.1-h02ab6af_0



Downloading and Extracting Packages

Preparing transaction: done
Verifying transaction: done
Executing transaction: done
#
# To activate this environment, use
#
#     $ conda activate mlagentsRec
#
# To deactivate an active environment, use
#
#     $ conda deactivate

(base) PS C:\Users\dexte> conda activate mlagentsRec
(mlagentsRec) PS C:\Users\dexte> pip install torch==2.2.2 --index-url https://download.pytorch.org/whl/cu121
Looking in indexes: https://download.pytorch.org/whl/cu121
Collecting torch==2.2.2
  Using cached https://download.pytorch.org/whl/cu121/torch-2.2.2%2Bcu121-cp310-cp310-win_amd64.whl (2454.8 MB)
Collecting filelock (from torch==2.2.2)
  Downloading https://download.pytorch.org/whl/filelock-3.19.1-py3-none-any.whl.metadata (2.1 kB)
Collecting typing-extensions>=4.8.0 (from torch==2.2.2)
  Downloading https://download.pytorch.org/whl/typing_extensions-4.15.0-py3-none-any.whl.metadata (3.3 kB)
Collecting sympy (from torch==2.2.2)
  Downloading https://download.pytorch.org/whl/sympy-1.14.0-py3-none-any.whl.metadata (12 kB)
Collecting networkx (from torch==2.2.2)
  Downloading https://download.pytorch.org/whl/networkx-3.5-py3-none-any.whl.metadata (6.3 kB)
Collecting jinja2 (from torch==2.2.2)
  Downloading https://download.pytorch.org/whl/jinja2-3.1.6-py3-none-any.whl.metadata (2.9 kB)
Collecting fsspec (from torch==2.2.2)
  Downloading https://download.pytorch.org/whl/fsspec-2025.9.0-py3-none-any.whl.metadata (10 kB)
Collecting MarkupSafe>=2.0 (from jinja2->torch==2.2.2)
  Using cached https://download.pytorch.org/whl/MarkupSafe-2.1.5-cp310-cp310-win_amd64.whl (17 kB)
INFO: pip is looking at multiple versions of networkx to determine which version is compatible with other requirements. This could take a while.
Collecting networkx (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/networkx-3.3-py3-none-any.whl.metadata (5.1 kB)
Collecting mpmath<1.4,>=1.1.0 (from sympy->torch==2.2.2)
  Using cached https://download.pytorch.org/whl/mpmath-1.3.0-py3-none-any.whl (536 kB)
Downloading https://download.pytorch.org/whl/typing_extensions-4.15.0-py3-none-any.whl (44 kB)
Downloading https://download.pytorch.org/whl/filelock-3.19.1-py3-none-any.whl (15 kB)
Downloading https://download.pytorch.org/whl/fsspec-2025.9.0-py3-none-any.whl (199 kB)
Downloading https://download.pytorch.org/whl/jinja2-3.1.6-py3-none-any.whl (134 kB)
Using cached https://download.pytorch.org/whl/networkx-3.3-py3-none-any.whl (1.7 MB)
Downloading https://download.pytorch.org/whl/sympy-1.14.0-py3-none-any.whl (6.3 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 6.3/6.3 MB 9.7 MB/s  0:00:00
Installing collected packages: mpmath, typing-extensions, sympy, networkx, MarkupSafe, fsspec, filelock, jinja2, torch
Successfully installed MarkupSafe-2.1.5 filelock-3.19.1 fsspec-2025.9.0 jinja2-3.1.6 mpmath-1.3.0 networkx-3.3 sympy-1.14.0 torch-2.2.2+cu121 typing-extensions-4.15.0
(mlagentsRec) PS C:\Users\dexte> pip install mlagents==0.30.0
ERROR: Ignored the following versions that require a different python version: 0.10.0.dev0 Requires-Python >=3.6,<3.7; 0.29.0 Requires-Python >=3.7.2,<3.10.0; 0.30.0 Requires-Python >=3.8.13,<=3.10.8; 0.5.0 Requires-Python >=3.6,<3.7; 0.6.0 Requires-Python >=3.6,<3.7; 0.7.0 Requires-Python >=3.6,<3.7; 0.8.0 Requires-Python >=3.6,<3.7; 0.8.1 Requires-Python >=3.6,<3.7; 0.8.2 Requires-Python >=3.6,<3.7; 0.9.0 Requires-Python >=3.6,<3.7; 0.9.1 Requires-Python >=3.6,<3.7; 0.9.2 Requires-Python >=3.6,<3.7; 0.9.3 Requires-Python >=3.6,<3.7
ERROR: Could not find a version that satisfies the requirement mlagents==0.30.0 (from versions: 0.4.0, 0.10.0.dev1, 0.10.0, 0.10.1, 0.11.0.dev0, 0.11.0, 0.12.0, 0.12.1, 0.13.0, 0.13.1, 0.14.0, 0.14.1, 0.15.0, 0.15.1, 0.16.0, 0.16.1, 0.17.0, 0.18.0, 0.18.1, 0.19.0, 0.20.0, 0.21.0, 0.21.1, 0.22.0, 0.23.0, 0.24.0, 0.24.1, 0.25.0, 0.25.1, 0.26.0, 0.27.0, 0.28.0, 1.0.0, 1.1.0)
ERROR: No matching distribution found for mlagents==0.30.0
(mlagentsRec) PS C:\Users\dexte> conda deactivate
(base) PS C:\Users\dexte> conda remove -n mlagentsRec --all -y

Remove all packages in environment C:\Users\dexte\anaconda3\envs\mlagentsRec:


## Package Plan ##

  environment location: C:\Users\dexte\anaconda3\envs\mlagentsRec


The following packages will be REMOVED:

  bzip2-1.0.8-h2bbff1b_6
  ca-certificates-2025.12.2-haa95532_0
  libffi-3.4.4-hd77b12b_1
  libzlib-1.3.1-h02ab6af_0
  openssl-3.0.18-h543e019_0
  pip-25.3-pyhc872135_0
  python-3.10.12-he1021f5_0
  setuptools-80.9.0-py310haa95532_0
  sqlite-3.51.0-hda9a48d_0
  tk-8.6.15-hf199647_0
  tzdata-2025b-h04d1e81_0
  ucrt-10.0.22621.0-haa95532_0
  vc-14.3-h2df5915_10
  vc14_runtime-14.44.35208-h4927774_10
  vs2015_runtime-14.44.35208-ha6b5a95_10
  wheel-0.45.1-py310haa95532_0
  xz-5.6.4-h4754444_1
  zlib-1.3.1-h02ab6af_0


Preparing transaction: done
Verifying transaction: done
Executing transaction: done
(base) PS C:\Users\dexte> conda create -n mlagentsRec python=3.9.18 -y
Collecting package metadata (current_repodata.json): done
Solving environment: unsuccessful attempt using repodata from current_repodata.json, retrying with next repodata source.
Collecting package metadata (repodata.json): done
Solving environment: done


==> WARNING: A newer version of conda exists. <==
  current version: 23.7.4
  latest version: 25.11.0

Please update conda by running

    $ conda update -n base -c defaults conda

Or to minimize the number of packages updated during conda update use

     conda install conda=25.11.0



## Package Plan ##

  environment location: C:\Users\dexte\anaconda3\envs\mlagentsRec

  added / updated specs:
    - python=3.9.18


The following packages will be downloaded:

    package                    |            build
    ---------------------------|-----------------
    python-3.9.18              |       h1aa4202_0        19.4 MB
    setuptools-80.9.0          |   py39haa95532_0         1.4 MB
    ------------------------------------------------------------
                                           Total:        20.8 MB

The following NEW packages will be INSTALLED:

  ca-certificates    pkgs/main/win-64::ca-certificates-2025.12.2-haa95532_0
  openssl            pkgs/main/win-64::openssl-3.0.18-h543e019_0
  pip                pkgs/main/noarch::pip-25.3-pyhc872135_0
  python             pkgs/main/win-64::python-3.9.18-h1aa4202_0
  setuptools         pkgs/main/win-64::setuptools-80.9.0-py39haa95532_0
  sqlite             pkgs/main/win-64::sqlite-3.51.0-hda9a48d_0
  tzdata             pkgs/main/noarch::tzdata-2025b-h04d1e81_0
  ucrt               pkgs/main/win-64::ucrt-10.0.22621.0-haa95532_0
  vc                 pkgs/main/win-64::vc-14.3-h2df5915_10
  vc14_runtime       pkgs/main/win-64::vc14_runtime-14.44.35208-h4927774_10
  vs2015_runtime     pkgs/main/win-64::vs2015_runtime-14.44.35208-ha6b5a95_10
  wheel              pkgs/main/win-64::wheel-0.45.1-py39haa95532_0



Downloading and Extracting Packages

Preparing transaction: done
Verifying transaction: done
Executing transaction: done
#
# To activate this environment, use
#
#     $ conda activate mlagentsRec
#
# To deactivate an active environment, use
#
#     $ conda deactivate

(base) PS C:\Users\dexte> conda activate mlagentsRec
(mlagentsRec) PS C:\Users\dexte> pip install torch==2.2.2 --index-url https://download.pytorch.org/whl/cu121
Looking in indexes: https://download.pytorch.org/whl/cu121
Collecting torch==2.2.2
  Downloading https://download.pytorch.org/whl/cu121/torch-2.2.2%2Bcu121-cp39-cp39-win_amd64.whl (2454.8 MB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 2.5/2.5 GB 6.5 MB/s  0:04:03
Collecting filelock (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/filelock-3.19.1-py3-none-any.whl.metadata (2.1 kB)
Collecting typing-extensions>=4.8.0 (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/typing_extensions-4.15.0-py3-none-any.whl.metadata (3.3 kB)
Collecting sympy (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/sympy-1.14.0-py3-none-any.whl.metadata (12 kB)
Collecting networkx (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/networkx-3.5-py3-none-any.whl.metadata (6.3 kB)
Collecting jinja2 (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/jinja2-3.1.6-py3-none-any.whl.metadata (2.9 kB)
Collecting fsspec (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/fsspec-2025.9.0-py3-none-any.whl.metadata (10 kB)
Collecting MarkupSafe>=2.0 (from jinja2->torch==2.2.2)
  Downloading https://download.pytorch.org/whl/MarkupSafe-2.1.5-cp39-cp39-win_amd64.whl (17 kB)
INFO: pip is looking at multiple versions of networkx to determine which version is compatible with other requirements. This could take a while.
Collecting networkx (from torch==2.2.2)
  Downloading https://download.pytorch.org/whl/networkx-3.2.1-py3-none-any.whl.metadata (5.2 kB)
Collecting mpmath<1.4,>=1.1.0 (from sympy->torch==2.2.2)
  Using cached https://download.pytorch.org/whl/mpmath-1.3.0-py3-none-any.whl (536 kB)
Using cached https://download.pytorch.org/whl/typing_extensions-4.15.0-py3-none-any.whl (44 kB)
Using cached https://download.pytorch.org/whl/filelock-3.19.1-py3-none-any.whl (15 kB)
Using cached https://download.pytorch.org/whl/fsspec-2025.9.0-py3-none-any.whl (199 kB)
Using cached https://download.pytorch.org/whl/jinja2-3.1.6-py3-none-any.whl (134 kB)
Downloading https://download.pytorch.org/whl/networkx-3.2.1-py3-none-any.whl (1.6 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 1.6/1.6 MB 8.9 MB/s  0:00:00
Using cached https://download.pytorch.org/whl/sympy-1.14.0-py3-none-any.whl (6.3 MB)
Installing collected packages: mpmath, typing-extensions, sympy, networkx, MarkupSafe, fsspec, filelock, jinja2, torch
Successfully installed MarkupSafe-2.1.5 filelock-3.19.1 fsspec-2025.9.0 jinja2-3.1.6 mpmath-1.3.0 networkx-3.2.1 sympy-1.14.0 torch-2.2.2+cu121 typing-extensions-4.15.0
(mlagentsRec) PS C:\Users\dexte> pip install mlagents==0.28.0
Collecting mlagents==0.28.0
  Downloading mlagents-0.28.0-py3-none-any.whl.metadata (2.5 kB)
Collecting grpcio>=1.11.0 (from mlagents==0.28.0)
  Downloading grpcio-1.76.0-cp39-cp39-win_amd64.whl.metadata (3.8 kB)
Collecting h5py>=2.9.0 (from mlagents==0.28.0)
  Downloading h5py-3.14.0-cp39-cp39-win_amd64.whl.metadata (2.7 kB)
Collecting mlagents-envs==0.28.0 (from mlagents==0.28.0)
  Downloading mlagents_envs-0.28.0-py3-none-any.whl.metadata (816 bytes)
Collecting numpy<2.0,>=1.13.3 (from mlagents==0.28.0)
  Downloading numpy-1.26.4-cp39-cp39-win_amd64.whl.metadata (61 kB)
Collecting Pillow>=4.2.1 (from mlagents==0.28.0)
  Downloading pillow-11.3.0-cp39-cp39-win_amd64.whl.metadata (9.2 kB)
Collecting protobuf>=3.6 (from mlagents==0.28.0)
  Downloading protobuf-6.33.1-cp39-cp39-win_amd64.whl.metadata (593 bytes)
Collecting pyyaml>=3.1.0 (from mlagents==0.28.0)
  Downloading pyyaml-6.0.3-cp39-cp39-win_amd64.whl.metadata (2.4 kB)
Collecting tensorboard>=1.15 (from mlagents==0.28.0)
  Downloading tensorboard-2.20.0-py3-none-any.whl.metadata (1.8 kB)
Collecting attrs>=19.3.0 (from mlagents==0.28.0)
  Downloading attrs-25.4.0-py3-none-any.whl.metadata (10 kB)
Collecting pypiwin32==223 (from mlagents==0.28.0)
  Using cached pypiwin32-223-py3-none-any.whl.metadata (236 bytes)
Collecting cattrs<1.7,>=1.1.0 (from mlagents==0.28.0)
  Using cached cattrs-1.5.0-py3-none-any.whl.metadata (16 kB)
Collecting cloudpickle (from mlagents-envs==0.28.0->mlagents==0.28.0)
  Downloading cloudpickle-3.1.2-py3-none-any.whl.metadata (7.1 kB)
Collecting pywin32>=223 (from pypiwin32==223->mlagents==0.28.0)
  Downloading pywin32-311-cp39-cp39-win_amd64.whl.metadata (10 kB)
Requirement already satisfied: typing-extensions~=4.12 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from grpcio>=1.11.0->mlagents==0.28.0) (4.15.0)
Collecting absl-py>=0.4 (from tensorboard>=1.15->mlagents==0.28.0)
  Downloading absl_py-2.3.1-py3-none-any.whl.metadata (3.3 kB)
Collecting markdown>=2.6.8 (from tensorboard>=1.15->mlagents==0.28.0)
  Downloading markdown-3.9-py3-none-any.whl.metadata (5.1 kB)
Collecting packaging (from tensorboard>=1.15->mlagents==0.28.0)
  Downloading packaging-25.0-py3-none-any.whl.metadata (3.3 kB)
Requirement already satisfied: setuptools>=41.0.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from tensorboard>=1.15->mlagents==0.28.0) (80.9.0)
Collecting tensorboard-data-server<0.8.0,>=0.7.0 (from tensorboard>=1.15->mlagents==0.28.0)
  Using cached tensorboard_data_server-0.7.2-py3-none-any.whl.metadata (1.1 kB)
Collecting werkzeug>=1.0.1 (from tensorboard>=1.15->mlagents==0.28.0)
  Downloading werkzeug-3.1.4-py3-none-any.whl.metadata (4.0 kB)
Collecting importlib-metadata>=4.4 (from markdown>=2.6.8->tensorboard>=1.15->mlagents==0.28.0)
  Downloading importlib_metadata-8.7.0-py3-none-any.whl.metadata (4.8 kB)
Collecting zipp>=3.20 (from importlib-metadata>=4.4->markdown>=2.6.8->tensorboard>=1.15->mlagents==0.28.0)
  Downloading zipp-3.23.0-py3-none-any.whl.metadata (3.6 kB)
Requirement already satisfied: markupsafe>=2.1.1 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from werkzeug>=1.0.1->tensorboard>=1.15->mlagents==0.28.0) (2.1.5)
Downloading mlagents-0.28.0-py3-none-any.whl (164 kB)
Downloading mlagents_envs-0.28.0-py3-none-any.whl (77 kB)
Using cached pypiwin32-223-py3-none-any.whl (1.7 kB)
Using cached cattrs-1.5.0-py3-none-any.whl (19 kB)
Downloading numpy-1.26.4-cp39-cp39-win_amd64.whl (15.8 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 15.8/15.8 MB 8.4 MB/s  0:00:01
Downloading attrs-25.4.0-py3-none-any.whl (67 kB)
Downloading grpcio-1.76.0-cp39-cp39-win_amd64.whl (4.7 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 4.7/4.7 MB 8.9 MB/s  0:00:00
Downloading h5py-3.14.0-cp39-cp39-win_amd64.whl (2.9 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 2.9/2.9 MB 8.4 MB/s  0:00:00
Downloading pillow-11.3.0-cp39-cp39-win_amd64.whl (7.0 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 7.0/7.0 MB 8.3 MB/s  0:00:00
Downloading protobuf-6.33.1-cp39-cp39-win_amd64.whl (436 kB)
Downloading pywin32-311-cp39-cp39-win_amd64.whl (9.6 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 9.6/9.6 MB 8.9 MB/s  0:00:01
Downloading pyyaml-6.0.3-cp39-cp39-win_amd64.whl (158 kB)
Downloading tensorboard-2.20.0-py3-none-any.whl (5.5 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 5.5/5.5 MB 8.4 MB/s  0:00:00
Using cached tensorboard_data_server-0.7.2-py3-none-any.whl (2.4 kB)
Downloading absl_py-2.3.1-py3-none-any.whl (135 kB)
Downloading markdown-3.9-py3-none-any.whl (107 kB)
Downloading importlib_metadata-8.7.0-py3-none-any.whl (27 kB)
Downloading werkzeug-3.1.4-py3-none-any.whl (224 kB)
Downloading zipp-3.23.0-py3-none-any.whl (10 kB)
Downloading cloudpickle-3.1.2-py3-none-any.whl (22 kB)
Downloading packaging-25.0-py3-none-any.whl (66 kB)
Installing collected packages: pywin32, zipp, werkzeug, tensorboard-data-server, pyyaml, pypiwin32, protobuf, Pillow, packaging, numpy, grpcio, cloudpickle, attrs, absl-py, mlagents-envs, importlib-metadata, h5py, cattrs, markdown, tensorboard, mlagents
Successfully installed Pillow-11.3.0 absl-py-2.3.1 attrs-25.4.0 cattrs-1.5.0 cloudpickle-3.1.2 grpcio-1.76.0 h5py-3.14.0 importlib-metadata-8.7.0 markdown-3.9 mlagents-0.28.0 mlagents-envs-0.28.0 numpy-1.26.4 packaging-25.0 protobuf-6.33.1 pypiwin32-223 pywin32-311 pyyaml-6.0.3 tensorboard-2.20.0 tensorboard-data-server-0.7.2 werkzeug-3.1.4 zipp-3.23.0
(mlagentsRec) PS C:\Users\dexte> mlagents-learn --version
C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\torch.py:4: UserWarning: pkg_resources is deprecated as an API. See https://setuptools.pypa.io/en/latest/pkg_resources.html. The pkg_resources package is slated for removal as early as 2025-11-30. Refrain from using this package or pin to Setuptools<81.
  import pkg_resources
Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 197, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 87, in _run_code
    exec(code, run_globals)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\Scripts\mlagents-learn.exe\__main__.py", line 2, in <module>
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\learn.py", line 2, in <module>
    from mlagents import torch_utils
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\__init__.py", line 1, in <module>
    from mlagents.torch_utils.torch import torch as torch  # noqa
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\torch.py", line 6, in <module>
    from mlagents.trainers.settings import TorchSettings
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\settings.py", line 25, in <module>
    from mlagents.trainers.cli_utils import StoreConfigFile, DetectDefault, parser
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\cli_utils.py", line 5, in <module>
    from mlagents_envs.environment import UnityEnvironment
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\environment.py", line 12, in <module>
    from mlagents_envs.side_channel.side_channel import SideChannel
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\side_channel\__init__.py", line 5, in <module>
    from mlagents_envs.side_channel.default_training_analytics_side_channel import (  # noqa
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\side_channel\default_training_analytics_side_channel.py", line 7, in <module>
    from mlagents_envs.communicator_objects.training_analytics_pb2 import (
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\communicator_objects\training_analytics_pb2.py", line 35, in <module>
    _descriptor.FieldDescriptor(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\google\protobuf\descriptor.py", line 675, in __new__
    _message.Message._CheckCalledFromGeneratedFile()
TypeError: Descriptors cannot be created directly.
If this call came from a _pb2.py file, your generated code is out of date and must be regenerated with protoc >= 3.19.0.
If you cannot immediately regenerate your protos, some other possible workarounds are:
 1. Downgrade the protobuf package to 3.20.x or lower.
 2. Set PROTOCOL_BUFFERS_PYTHON_IMPLEMENTATION=python (but this will use pure-Python parsing and will be much slower).

More information: https://developers.google.com/protocol-buffers/docs/news/2022-05-06#python-updates
(mlagentsRec) PS C:\Users\dexte> conda create -n mlagentsRec python=3.9.18 -y
Collecting package metadata (current_repodata.json): done
Solving environment: unsuccessful attempt using repodata from current_repodata.json, retrying with next repodata source.
Collecting package metadata (repodata.json): done
Solving environment: done


==> WARNING: A newer version of conda exists. <==
  current version: 23.7.4
  latest version: 25.11.0

Please update conda by running

    $ conda update -n base -c defaults conda

Or to minimize the number of packages updated during conda update use

     conda install conda=25.11.0



## Package Plan ##

  environment location: C:\Users\dexte\anaconda3\envs\mlagentsRec

  added / updated specs:
    - python=3.9.18


The following NEW packages will be INSTALLED:

  ca-certificates    pkgs/main/win-64::ca-certificates-2025.12.2-haa95532_0
  openssl            pkgs/main/win-64::openssl-3.0.18-h543e019_0
  pip                pkgs/main/noarch::pip-25.3-pyhc872135_0
  python             pkgs/main/win-64::python-3.9.18-h1aa4202_0
  setuptools         pkgs/main/win-64::setuptools-80.9.0-py39haa95532_0
  sqlite             pkgs/main/win-64::sqlite-3.51.0-hda9a48d_0
  tzdata             pkgs/main/noarch::tzdata-2025b-h04d1e81_0
  ucrt               pkgs/main/win-64::ucrt-10.0.22621.0-haa95532_0
  vc                 pkgs/main/win-64::vc-14.3-h2df5915_10
  vc14_runtime       pkgs/main/win-64::vc14_runtime-14.44.35208-h4927774_10
  vs2015_runtime     pkgs/main/win-64::vs2015_runtime-14.44.35208-ha6b5a95_10
  wheel              pkgs/main/win-64::wheel-0.45.1-py39haa95532_0



Downloading and Extracting Packages

Preparing transaction: done
Verifying transaction: done
Executing transaction: done
#
# To activate this environment, use
#
#     $ conda activate mlagentsRec
#
# To deactivate an active environment, use
#
#     $ conda deactivate

(mlagentsRec) PS C:\Users\dexte> conda activate mlagentsRec
(mlagentsRec) PS C:\Users\dexte> pip install torch==2.2.2 --index-url https://download.pytorch.org/whl/cu121
Looking in indexes: https://download.pytorch.org/whl/cu121
Collecting torch==2.2.2
  Using cached https://download.pytorch.org/whl/cu121/torch-2.2.2%2Bcu121-cp39-cp39-win_amd64.whl (2454.8 MB)
Collecting filelock (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/filelock-3.19.1-py3-none-any.whl.metadata (2.1 kB)
Collecting typing-extensions>=4.8.0 (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/typing_extensions-4.15.0-py3-none-any.whl.metadata (3.3 kB)
Collecting sympy (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/sympy-1.14.0-py3-none-any.whl.metadata (12 kB)
Collecting networkx (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/networkx-3.5-py3-none-any.whl.metadata (6.3 kB)
Collecting jinja2 (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/jinja2-3.1.6-py3-none-any.whl.metadata (2.9 kB)
Collecting fsspec (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/fsspec-2025.9.0-py3-none-any.whl.metadata (10 kB)
Collecting MarkupSafe>=2.0 (from jinja2->torch==2.2.2)
  Using cached https://download.pytorch.org/whl/MarkupSafe-2.1.5-cp39-cp39-win_amd64.whl (17 kB)
INFO: pip is looking at multiple versions of networkx to determine which version is compatible with other requirements. This could take a while.
Collecting networkx (from torch==2.2.2)
  Using cached https://download.pytorch.org/whl/networkx-3.2.1-py3-none-any.whl.metadata (5.2 kB)
Collecting mpmath<1.4,>=1.1.0 (from sympy->torch==2.2.2)
  Using cached https://download.pytorch.org/whl/mpmath-1.3.0-py3-none-any.whl (536 kB)
Using cached https://download.pytorch.org/whl/typing_extensions-4.15.0-py3-none-any.whl (44 kB)
Using cached https://download.pytorch.org/whl/filelock-3.19.1-py3-none-any.whl (15 kB)
Using cached https://download.pytorch.org/whl/fsspec-2025.9.0-py3-none-any.whl (199 kB)
Using cached https://download.pytorch.org/whl/jinja2-3.1.6-py3-none-any.whl (134 kB)
Using cached https://download.pytorch.org/whl/networkx-3.2.1-py3-none-any.whl (1.6 MB)
Using cached https://download.pytorch.org/whl/sympy-1.14.0-py3-none-any.whl (6.3 MB)
Installing collected packages: mpmath, typing-extensions, sympy, networkx, MarkupSafe, fsspec, filelock, jinja2, torch
Successfully installed MarkupSafe-2.1.5 filelock-3.19.1 fsspec-2025.9.0 jinja2-3.1.6 mpmath-1.3.0 networkx-3.2.1 sympy-1.14.0 torch-2.2.2+cu121 typing-extensions-4.15.0
(mlagentsRec) PS C:\Users\dexte> pip install mlagents==0.28.0
Collecting mlagents==0.28.0
  Using cached mlagents-0.28.0-py3-none-any.whl.metadata (2.5 kB)
Collecting grpcio>=1.11.0 (from mlagents==0.28.0)
  Using cached grpcio-1.76.0-cp39-cp39-win_amd64.whl.metadata (3.8 kB)
Collecting h5py>=2.9.0 (from mlagents==0.28.0)
  Using cached h5py-3.14.0-cp39-cp39-win_amd64.whl.metadata (2.7 kB)
Collecting mlagents-envs==0.28.0 (from mlagents==0.28.0)
  Using cached mlagents_envs-0.28.0-py3-none-any.whl.metadata (816 bytes)
Collecting numpy<2.0,>=1.13.3 (from mlagents==0.28.0)
  Using cached numpy-1.26.4-cp39-cp39-win_amd64.whl.metadata (61 kB)
Collecting Pillow>=4.2.1 (from mlagents==0.28.0)
  Using cached pillow-11.3.0-cp39-cp39-win_amd64.whl.metadata (9.2 kB)
Collecting protobuf>=3.6 (from mlagents==0.28.0)
  Using cached protobuf-6.33.1-cp39-cp39-win_amd64.whl.metadata (593 bytes)
Collecting pyyaml>=3.1.0 (from mlagents==0.28.0)
  Using cached pyyaml-6.0.3-cp39-cp39-win_amd64.whl.metadata (2.4 kB)
Collecting tensorboard>=1.15 (from mlagents==0.28.0)
  Using cached tensorboard-2.20.0-py3-none-any.whl.metadata (1.8 kB)
Collecting attrs>=19.3.0 (from mlagents==0.28.0)
  Using cached attrs-25.4.0-py3-none-any.whl.metadata (10 kB)
Collecting pypiwin32==223 (from mlagents==0.28.0)
  Using cached pypiwin32-223-py3-none-any.whl.metadata (236 bytes)
Collecting cattrs<1.7,>=1.1.0 (from mlagents==0.28.0)
  Using cached cattrs-1.5.0-py3-none-any.whl.metadata (16 kB)
Collecting cloudpickle (from mlagents-envs==0.28.0->mlagents==0.28.0)
  Using cached cloudpickle-3.1.2-py3-none-any.whl.metadata (7.1 kB)
Collecting pywin32>=223 (from pypiwin32==223->mlagents==0.28.0)
  Using cached pywin32-311-cp39-cp39-win_amd64.whl.metadata (10 kB)
Requirement already satisfied: typing-extensions~=4.12 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from grpcio>=1.11.0->mlagents==0.28.0) (4.15.0)
Collecting absl-py>=0.4 (from tensorboard>=1.15->mlagents==0.28.0)
  Using cached absl_py-2.3.1-py3-none-any.whl.metadata (3.3 kB)
Collecting markdown>=2.6.8 (from tensorboard>=1.15->mlagents==0.28.0)
  Using cached markdown-3.9-py3-none-any.whl.metadata (5.1 kB)
Collecting packaging (from tensorboard>=1.15->mlagents==0.28.0)
  Using cached packaging-25.0-py3-none-any.whl.metadata (3.3 kB)
Requirement already satisfied: setuptools>=41.0.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from tensorboard>=1.15->mlagents==0.28.0) (80.9.0)
Collecting tensorboard-data-server<0.8.0,>=0.7.0 (from tensorboard>=1.15->mlagents==0.28.0)
  Using cached tensorboard_data_server-0.7.2-py3-none-any.whl.metadata (1.1 kB)
Collecting werkzeug>=1.0.1 (from tensorboard>=1.15->mlagents==0.28.0)
  Using cached werkzeug-3.1.4-py3-none-any.whl.metadata (4.0 kB)
Collecting importlib-metadata>=4.4 (from markdown>=2.6.8->tensorboard>=1.15->mlagents==0.28.0)
  Using cached importlib_metadata-8.7.0-py3-none-any.whl.metadata (4.8 kB)
Collecting zipp>=3.20 (from importlib-metadata>=4.4->markdown>=2.6.8->tensorboard>=1.15->mlagents==0.28.0)
  Using cached zipp-3.23.0-py3-none-any.whl.metadata (3.6 kB)
Requirement already satisfied: markupsafe>=2.1.1 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from werkzeug>=1.0.1->tensorboard>=1.15->mlagents==0.28.0) (2.1.5)
Using cached mlagents-0.28.0-py3-none-any.whl (164 kB)
Using cached mlagents_envs-0.28.0-py3-none-any.whl (77 kB)
Using cached pypiwin32-223-py3-none-any.whl (1.7 kB)
Using cached cattrs-1.5.0-py3-none-any.whl (19 kB)
Using cached numpy-1.26.4-cp39-cp39-win_amd64.whl (15.8 MB)
Using cached attrs-25.4.0-py3-none-any.whl (67 kB)
Using cached grpcio-1.76.0-cp39-cp39-win_amd64.whl (4.7 MB)
Using cached h5py-3.14.0-cp39-cp39-win_amd64.whl (2.9 MB)
Using cached pillow-11.3.0-cp39-cp39-win_amd64.whl (7.0 MB)
Using cached protobuf-6.33.1-cp39-cp39-win_amd64.whl (436 kB)
Using cached pywin32-311-cp39-cp39-win_amd64.whl (9.6 MB)
Using cached pyyaml-6.0.3-cp39-cp39-win_amd64.whl (158 kB)
Using cached tensorboard-2.20.0-py3-none-any.whl (5.5 MB)
Using cached tensorboard_data_server-0.7.2-py3-none-any.whl (2.4 kB)
Using cached absl_py-2.3.1-py3-none-any.whl (135 kB)
Using cached markdown-3.9-py3-none-any.whl (107 kB)
Using cached importlib_metadata-8.7.0-py3-none-any.whl (27 kB)
Using cached werkzeug-3.1.4-py3-none-any.whl (224 kB)
Using cached zipp-3.23.0-py3-none-any.whl (10 kB)
Using cached cloudpickle-3.1.2-py3-none-any.whl (22 kB)
Using cached packaging-25.0-py3-none-any.whl (66 kB)
Installing collected packages: pywin32, zipp, werkzeug, tensorboard-data-server, pyyaml, pypiwin32, protobuf, Pillow, packaging, numpy, grpcio, cloudpickle, attrs, absl-py, mlagents-envs, importlib-metadata, h5py, cattrs, markdown, tensorboard, mlagents
Successfully installed Pillow-11.3.0 absl-py-2.3.1 attrs-25.4.0 cattrs-1.5.0 cloudpickle-3.1.2 grpcio-1.76.0 h5py-3.14.0 importlib-metadata-8.7.0 markdown-3.9 mlagents-0.28.0 mlagents-envs-0.28.0 numpy-1.26.4 packaging-25.0 protobuf-6.33.1 pypiwin32-223 pywin32-311 pyyaml-6.0.3 tensorboard-2.20.0 tensorboard-data-server-0.7.2 werkzeug-3.1.4 zipp-3.23.0
(mlagentsRec) PS C:\Users\dexte> mlagents-learn --version
C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\torch.py:4: UserWarning: pkg_resources is deprecated as an API. See https://setuptools.pypa.io/en/latest/pkg_resources.html. The pkg_resources package is slated for removal as early as 2025-11-30. Refrain from using this package or pin to Setuptools<81.
  import pkg_resources
Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 197, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 87, in _run_code
    exec(code, run_globals)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\Scripts\mlagents-learn.exe\__main__.py", line 2, in <module>
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\learn.py", line 2, in <module>
    from mlagents import torch_utils
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\__init__.py", line 1, in <module>
    from mlagents.torch_utils.torch import torch as torch  # noqa
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\torch.py", line 6, in <module>
    from mlagents.trainers.settings import TorchSettings
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\settings.py", line 25, in <module>
    from mlagents.trainers.cli_utils import StoreConfigFile, DetectDefault, parser
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\cli_utils.py", line 5, in <module>
    from mlagents_envs.environment import UnityEnvironment
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\environment.py", line 12, in <module>
    from mlagents_envs.side_channel.side_channel import SideChannel
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\side_channel\__init__.py", line 5, in <module>
    from mlagents_envs.side_channel.default_training_analytics_side_channel import (  # noqa
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\side_channel\default_training_analytics_side_channel.py", line 7, in <module>
    from mlagents_envs.communicator_objects.training_analytics_pb2 import (
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\communicator_objects\training_analytics_pb2.py", line 35, in <module>
    _descriptor.FieldDescriptor(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\google\protobuf\descriptor.py", line 675, in __new__
    _message.Message._CheckCalledFromGeneratedFile()
TypeError: Descriptors cannot be created directly.
If this call came from a _pb2.py file, your generated code is out of date and must be regenerated with protoc >= 3.19.0.
If you cannot immediately regenerate your protos, some other possible workarounds are:
 1. Downgrade the protobuf package to 3.20.x or lower.
 2. Set PROTOCOL_BUFFERS_PYTHON_IMPLEMENTATION=python (but this will use pure-Python parsing and will be much slower).

More information: https://developers.google.com/protocol-buffers/docs/news/2022-05-06#python-updates
(mlagentsRec) PS C:\Users\dexte> pip install protobuf==3.20.3
Collecting protobuf==3.20.3
  Downloading protobuf-3.20.3-cp39-cp39-win_amd64.whl.metadata (699 bytes)
Downloading protobuf-3.20.3-cp39-cp39-win_amd64.whl (904 kB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 904.2/904.2 kB 5.1 MB/s  0:00:00
Installing collected packages: protobuf
  Attempting uninstall: protobuf
    Found existing installation: protobuf 6.33.1
    Uninstalling protobuf-6.33.1:
      Successfully uninstalled protobuf-6.33.1
Successfully installed protobuf-3.20.3
(mlagentsRec) PS C:\Users\dexte> mlagents-learn --version
C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\torch.py:4: UserWarning: pkg_resources is deprecated as an API. See https://setuptools.pypa.io/en/latest/pkg_resources.html. The pkg_resources package is slated for removal as early as 2025-11-30. Refrain from using this package or pin to Setuptools<81.
  import pkg_resources
Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 197, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 87, in _run_code
    exec(code, run_globals)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\Scripts\mlagents-learn.exe\__main__.py", line 2, in <module>
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\learn.py", line 2, in <module>
    from mlagents import torch_utils
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\__init__.py", line 1, in <module>
    from mlagents.torch_utils.torch import torch as torch  # noqa
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\torch.py", line 6, in <module>
    from mlagents.trainers.settings import TorchSettings
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\settings.py", line 644, in <module>
    class TrainerSettings(ExportableSettings):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\settings.py", line 667, in TrainerSettings
    cattr.register_structure_hook(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\cattr\converters.py", line 207, in register_structure_hook
    self._structure_func.register_cls_list([(cl, func)])
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\cattr\dispatch.py", line 55, in register_cls_list
    self._single_dispatch.register(cls, handler)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\functools.py", line 855, in register
    raise TypeError(
TypeError: Invalid first argument to `register()`. typing.Dict[mlagents.trainers.settings.RewardSignalType, mlagents.trainers.settings.RewardSignalSettings] is not a class.
(mlagentsRec) PS C:\Users\dexte> pip install cattrs==1.1.2
Collecting cattrs==1.1.2
  Downloading cattrs-1.1.2-py3-none-any.whl.metadata (13 kB)
Requirement already satisfied: attrs>=20.1.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from cattrs==1.1.2) (25.4.0)
Downloading cattrs-1.1.2-py3-none-any.whl (17 kB)
Installing collected packages: cattrs
  Attempting uninstall: cattrs
    Found existing installation: cattrs 1.5.0
    Uninstalling cattrs-1.5.0:
      Successfully uninstalled cattrs-1.5.0
Successfully installed cattrs-1.1.2
(mlagentsRec) PS C:\Users\dexte> mlagents-learn --version
C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\torch.py:4: UserWarning: pkg_resources is deprecated as an API. See https://setuptools.pypa.io/en/latest/pkg_resources.html. The pkg_resources package is slated for removal as early as 2025-11-30. Refrain from using this package or pin to Setuptools<81.
  import pkg_resources
Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 197, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 87, in _run_code
    exec(code, run_globals)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\Scripts\mlagents-learn.exe\__main__.py", line 2, in <module>
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\learn.py", line 2, in <module>
    from mlagents import torch_utils
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\__init__.py", line 1, in <module>
    from mlagents.torch_utils.torch import torch as torch  # noqa
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\torch.py", line 6, in <module>
    from mlagents.trainers.settings import TorchSettings
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\settings.py", line 644, in <module>
    class TrainerSettings(ExportableSettings):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\settings.py", line 667, in TrainerSettings
    cattr.register_structure_hook(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\cattr\converters.py", line 186, in register_structure_hook
    self._structure_func.register_cls_list([(cl, func)])
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\cattr\multistrategy_dispatch.py", line 45, in register_cls_list
    self._single_dispatch.register(cls, handler)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\functools.py", line 855, in register
    raise TypeError(
TypeError: Invalid first argument to `register()`. typing.Dict[mlagents.trainers.settings.RewardSignalType, mlagents.trainers.settings.RewardSignalSettings] is not a class.
(mlagentsRec) PS C:\Users\dexte> pip uninstall mlagents mlagents-envs -y
Found existing installation: mlagents 0.28.0
Uninstalling mlagents-0.28.0:
  Successfully uninstalled mlagents-0.28.0
Found existing installation: mlagents-envs 0.28.0
Uninstalling mlagents-envs-0.28.0:
  Successfully uninstalled mlagents-envs-0.28.0
(mlagentsRec) PS C:\Users\dexte> pip install git+https://github.com/Unity-Technologies/ml-agents.git@release_18#subdirectory=ml-agents-envs
Collecting git+https://github.com/Unity-Technologies/ml-agents.git@release_18#subdirectory=ml-agents-envs
  Cloning https://github.com/Unity-Technologies/ml-agents.git (to revision release_18) to c:\users\dexte\appdata\local\temp\pip-req-build-rzkdkek_
  Running command git clone --filter=blob:none --quiet https://github.com/Unity-Technologies/ml-agents.git 'C:\Users\dexte\AppData\Local\Temp\pip-req-build-rzkdkek_'
  Running command git checkout -q c1b26d49e4f4fc692c2688531f9e7c69dba12682
  Resolved https://github.com/Unity-Technologies/ml-agents.git to commit c1b26d49e4f4fc692c2688531f9e7c69dba12682
  Installing build dependencies ... done
  Getting requirements to build wheel ... done
  Preparing metadata (pyproject.toml) ... done
Requirement already satisfied: cloudpickle in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents_envs==0.27.0) (3.1.2)
Requirement already satisfied: grpcio>=1.11.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents_envs==0.27.0) (1.76.0)
Requirement already satisfied: numpy>=1.14.1 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents_envs==0.27.0) (1.26.4)
Requirement already satisfied: Pillow>=4.2.1 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents_envs==0.27.0) (11.3.0)
Requirement already satisfied: protobuf>=3.6 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents_envs==0.27.0) (3.20.3)
Requirement already satisfied: pyyaml>=3.1.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents_envs==0.27.0) (6.0.3)
Requirement already satisfied: typing-extensions~=4.12 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from grpcio>=1.11.0->mlagents_envs==0.27.0) (4.15.0)
Building wheels for collected packages: mlagents_envs
  Building wheel for mlagents_envs (pyproject.toml) ... done
  Created wheel for mlagents_envs: filename=mlagents_envs-0.27.0-py3-none-any.whl size=94895 sha256=22d5a49df12c41cad4898262197961c154aca37638ea92e642718ba2b5f7a9b2
  Stored in directory: C:\Users\dexte\AppData\Local\Temp\pip-ephem-wheel-cache-gml0ktcs\wheels\20\fd\9d\61a1ce645dbc62e72a2210c17738e8a284ee7adec0da0f2232
Successfully built mlagents_envs
Installing collected packages: mlagents_envs
Successfully installed mlagents_envs-0.27.0
(mlagentsRec) PS C:\Users\dexte> pip install git+https://github.com/Unity-Technologies/ml-agents.git@release_18#subdirectory=ml-agents
Collecting git+https://github.com/Unity-Technologies/ml-agents.git@release_18#subdirectory=ml-agents
  Cloning https://github.com/Unity-Technologies/ml-agents.git (to revision release_18) to c:\users\dexte\appdata\local\temp\pip-req-build-3cp8fsjk
  Running command git clone --filter=blob:none --quiet https://github.com/Unity-Technologies/ml-agents.git 'C:\Users\dexte\AppData\Local\Temp\pip-req-build-3cp8fsjk'
  Running command git checkout -q c1b26d49e4f4fc692c2688531f9e7c69dba12682
  Resolved https://github.com/Unity-Technologies/ml-agents.git to commit c1b26d49e4f4fc692c2688531f9e7c69dba12682
  Installing build dependencies ... done
  Getting requirements to build wheel ... done
  Preparing metadata (pyproject.toml) ... done
Requirement already satisfied: grpcio>=1.11.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents==0.27.0) (1.76.0)
Requirement already satisfied: h5py>=2.9.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents==0.27.0) (3.14.0)
Requirement already satisfied: mlagents_envs==0.27.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents==0.27.0) (0.27.0)
Requirement already satisfied: numpy<2.0,>=1.13.3 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents==0.27.0) (1.26.4)
Requirement already satisfied: Pillow>=4.2.1 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents==0.27.0) (11.3.0)
Requirement already satisfied: protobuf>=3.6 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents==0.27.0) (3.20.3)
Requirement already satisfied: pyyaml>=3.1.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents==0.27.0) (6.0.3)
Requirement already satisfied: tensorboard>=1.15 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents==0.27.0) (2.20.0)
Requirement already satisfied: cattrs<1.7,>=1.1.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents==0.27.0) (1.1.2)
Requirement already satisfied: attrs>=19.3.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents==0.27.0) (25.4.0)
Requirement already satisfied: pypiwin32==223 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents==0.27.0) (223)
Requirement already satisfied: cloudpickle in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from mlagents_envs==0.27.0->mlagents==0.27.0) (3.1.2)
Requirement already satisfied: pywin32>=223 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from pypiwin32==223->mlagents==0.27.0) (311)
Requirement already satisfied: typing-extensions~=4.12 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from grpcio>=1.11.0->mlagents==0.27.0) (4.15.0)
Requirement already satisfied: absl-py>=0.4 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from tensorboard>=1.15->mlagents==0.27.0) (2.3.1)
Requirement already satisfied: markdown>=2.6.8 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from tensorboard>=1.15->mlagents==0.27.0) (3.9)
Requirement already satisfied: packaging in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from tensorboard>=1.15->mlagents==0.27.0) (25.0)
Requirement already satisfied: setuptools>=41.0.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from tensorboard>=1.15->mlagents==0.27.0) (80.9.0)
Requirement already satisfied: tensorboard-data-server<0.8.0,>=0.7.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from tensorboard>=1.15->mlagents==0.27.0) (0.7.2)
Requirement already satisfied: werkzeug>=1.0.1 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from tensorboard>=1.15->mlagents==0.27.0) (3.1.4)
Requirement already satisfied: importlib-metadata>=4.4 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from markdown>=2.6.8->tensorboard>=1.15->mlagents==0.27.0) (8.7.0)
Requirement already satisfied: zipp>=3.20 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from importlib-metadata>=4.4->markdown>=2.6.8->tensorboard>=1.15->mlagents==0.27.0) (3.23.0)
Requirement already satisfied: markupsafe>=2.1.1 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from werkzeug>=1.0.1->tensorboard>=1.15->mlagents==0.27.0) (2.1.5)
Building wheels for collected packages: mlagents
  Building wheel for mlagents (pyproject.toml) ... done
  Created wheel for mlagents: filename=mlagents-0.27.0-py3-none-any.whl size=161643 sha256=43e657d2b979a5cbce8435165477da8a6ecf6cfb935457ae33e89dcb5ea687e5
  Stored in directory: C:\Users\dexte\AppData\Local\Temp\pip-ephem-wheel-cache-1s_zahw_\wheels\b5\32\40\2690bd55445403e581c977ac205fef2356eab68d44b2ed37c1
Successfully built mlagents
Installing collected packages: mlagents
Successfully installed mlagents-0.27.0
(mlagentsRec) PS C:\Users\dexte> mlagents-learn --version
C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\torch.py:4: UserWarning: pkg_resources is deprecated as an API. See https://setuptools.pypa.io/en/latest/pkg_resources.html. The pkg_resources package is slated for removal as early as 2025-11-30. Refrain from using this package or pin to Setuptools<81.
  import pkg_resources
Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 197, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 87, in _run_code
    exec(code, run_globals)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\Scripts\mlagents-learn.exe\__main__.py", line 2, in <module>
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\learn.py", line 2, in <module>
    from mlagents import torch_utils
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\__init__.py", line 1, in <module>
    from mlagents.torch_utils.torch import torch as torch  # noqa
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\torch_utils\torch.py", line 6, in <module>
    from mlagents.trainers.settings import TorchSettings
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\settings.py", line 626, in <module>
    class TrainerSettings(ExportableSettings):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\settings.py", line 649, in TrainerSettings
    cattr.register_structure_hook(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\cattr\converters.py", line 186, in register_structure_hook
    self._structure_func.register_cls_list([(cl, func)])
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\cattr\multistrategy_dispatch.py", line 45, in register_cls_list
    self._single_dispatch.register(cls, handler)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\functools.py", line 855, in register
    raise TypeError(
TypeError: Invalid first argument to `register()`. typing.Dict[mlagents.trainers.settings.RewardSignalType, mlagents.trainers.settings.RewardSignalSettings] is not a class.
(mlagentsRec) PS C:\Users\dexte> conda deactivate
(base) PS C:\Users\dexte> conda remove -n mlagentsRec --all -y

Remove all packages in environment C:\Users\dexte\anaconda3\envs\mlagentsRec:


## Package Plan ##

  environment location: C:\Users\dexte\anaconda3\envs\mlagentsRec


The following packages will be REMOVED:

  ca-certificates-2025.12.2-haa95532_0
  openssl-3.0.18-h543e019_0
  pip-25.3-pyhc872135_0
  python-3.9.18-h1aa4202_0
  setuptools-80.9.0-py39haa95532_0
  sqlite-3.51.0-hda9a48d_0
  tzdata-2025b-h04d1e81_0
  ucrt-10.0.22621.0-haa95532_0
  vc-14.3-h2df5915_10
  vc14_runtime-14.44.35208-h4927774_10
  vs2015_runtime-14.44.35208-ha6b5a95_10
  wheel-0.45.1-py39haa95532_0


Preparing transaction: done
Verifying transaction: done
Executing transaction: done
(base) PS C:\Users\dexte> conda create -n mlagentsRec python=3.8.18 -y
Collecting package metadata (current_repodata.json): done
Solving environment: unsuccessful attempt using repodata from current_repodata.json, retrying with next repodata source.
Collecting package metadata (repodata.json): done
Solving environment: done


==> WARNING: A newer version of conda exists. <==
  current version: 23.7.4
  latest version: 25.11.0

Please update conda by running

    $ conda update -n base -c defaults conda

Or to minimize the number of packages updated during conda update use

     conda install conda=25.11.0



## Package Plan ##

  environment location: C:\Users\dexte\anaconda3\envs\mlagentsRec

  added / updated specs:
    - python=3.8.18


The following packages will be downloaded:

    package                    |            build
    ---------------------------|-----------------
    pip-24.2                   |   py38haa95532_0         2.4 MB
    python-3.8.18              |       h1aa4202_0        20.5 MB
    setuptools-75.1.0          |   py38haa95532_0         1.6 MB
    wheel-0.44.0               |   py38haa95532_0         137 KB
    ------------------------------------------------------------
                                           Total:        24.6 MB

The following NEW packages will be INSTALLED:

  ca-certificates    pkgs/main/win-64::ca-certificates-2025.12.2-haa95532_0
  libffi             pkgs/main/win-64::libffi-3.4.4-hd77b12b_1
  openssl            pkgs/main/win-64::openssl-3.0.18-h543e019_0
  pip                pkgs/main/win-64::pip-24.2-py38haa95532_0
  python             pkgs/main/win-64::python-3.8.18-h1aa4202_0
  setuptools         pkgs/main/win-64::setuptools-75.1.0-py38haa95532_0
  sqlite             pkgs/main/win-64::sqlite-3.51.0-hda9a48d_0
  ucrt               pkgs/main/win-64::ucrt-10.0.22621.0-haa95532_0
  vc                 pkgs/main/win-64::vc-14.3-h2df5915_10
  vc14_runtime       pkgs/main/win-64::vc14_runtime-14.44.35208-h4927774_10
  vs2015_runtime     pkgs/main/win-64::vs2015_runtime-14.44.35208-ha6b5a95_10
  wheel              pkgs/main/win-64::wheel-0.44.0-py38haa95532_0



Downloading and Extracting Packages

Preparing transaction: done
Verifying transaction: done
Executing transaction: done
#
# To activate this environment, use
#
#     $ conda activate mlagentsRec
#
# To deactivate an active environment, use
#
#     $ conda deactivate

(base) PS C:\Users\dexte> conda activate mlagentsRec
(mlagentsRec) PS C:\Users\dexte> pip install torch==2.0.1 --index-url https://download.pytorch.org/whl/cu118
Looking in indexes: https://download.pytorch.org/whl/cu118
Collecting torch==2.0.1
  Downloading https://download.pytorch.org/whl/cu118/torch-2.0.1%2Bcu118-cp38-cp38-win_amd64.whl (2619.2 MB)
     ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 2.6/2.6 GB 5.2 MB/s eta 0:00:00
Collecting filelock (from torch==2.0.1)
  Using cached https://download.pytorch.org/whl/filelock-3.19.1-py3-none-any.whl.metadata (2.1 kB)
Collecting typing-extensions (from torch==2.0.1)
  Using cached https://download.pytorch.org/whl/typing_extensions-4.15.0-py3-none-any.whl.metadata (3.3 kB)
Collecting sympy (from torch==2.0.1)
  Using cached https://download.pytorch.org/whl/sympy-1.14.0-py3-none-any.whl.metadata (12 kB)
Collecting networkx (from torch==2.0.1)
  Using cached https://download.pytorch.org/whl/networkx-3.5-py3-none-any.whl.metadata (6.3 kB)
Collecting jinja2 (from torch==2.0.1)
  Using cached https://download.pytorch.org/whl/jinja2-3.1.6-py3-none-any.whl.metadata (2.9 kB)
INFO: pip is looking at multiple versions of filelock to determine which version is compatible with other requirements. This could take a while.
Collecting filelock (from torch==2.0.1)
  Using cached https://download.pytorch.org/whl/filelock-3.13.1-py3-none-any.whl.metadata (2.8 kB)
Collecting MarkupSafe>=2.0 (from jinja2->torch==2.0.1)
  Downloading https://download.pytorch.org/whl/MarkupSafe-2.1.5-cp38-cp38-win_amd64.whl (17 kB)
INFO: pip is looking at multiple versions of networkx to determine which version is compatible with other requirements. This could take a while.
Collecting networkx (from torch==2.0.1)
  Using cached https://download.pytorch.org/whl/networkx-3.2.1-py3-none-any.whl.metadata (5.2 kB)
  Downloading https://download.pytorch.org/whl/networkx-3.0-py3-none-any.whl.metadata (5.1 kB)
Collecting mpmath<1.4,>=1.1.0 (from sympy->torch==2.0.1)
  Using cached https://download.pytorch.org/whl/mpmath-1.3.0-py3-none-any.whl (536 kB)
INFO: pip is looking at multiple versions of sympy to determine which version is compatible with other requirements. This could take a while.
Collecting sympy (from torch==2.0.1)
  Downloading https://download.pytorch.org/whl/sympy-1.13.3-py3-none-any.whl.metadata (12 kB)
INFO: pip is looking at multiple versions of typing-extensions to determine which version is compatible with other requirements. This could take a while.
Collecting typing-extensions (from torch==2.0.1)
  Downloading https://download.pytorch.org/whl/typing_extensions-4.14.0-py3-none-any.whl.metadata (3.0 kB)
  Using cached https://download.pytorch.org/whl/typing_extensions-4.12.2-py3-none-any.whl.metadata (3.0 kB)
Using cached https://download.pytorch.org/whl/filelock-3.13.1-py3-none-any.whl (11 kB)
Using cached https://download.pytorch.org/whl/jinja2-3.1.6-py3-none-any.whl (134 kB)
Downloading https://download.pytorch.org/whl/networkx-3.0-py3-none-any.whl (2.0 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 2.0/2.0 MB 10.4 MB/s eta 0:00:00
Downloading https://download.pytorch.org/whl/sympy-1.13.3-py3-none-any.whl (6.2 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 6.2/6.2 MB 9.2 MB/s eta 0:00:00
Using cached https://download.pytorch.org/whl/typing_extensions-4.12.2-py3-none-any.whl (37 kB)
Installing collected packages: mpmath, typing-extensions, sympy, networkx, MarkupSafe, filelock, jinja2, torch
Successfully installed MarkupSafe-2.1.5 filelock-3.13.1 jinja2-3.1.6 mpmath-1.3.0 networkx-3.0 sympy-1.13.3 torch-2.0.1+cu118 typing-extensions-4.12.2
(mlagentsRec) PS C:\Users\dexte> pip install mlagents==0.28.0 protobuf==3.20.3
Collecting mlagents==0.28.0
  Using cached mlagents-0.28.0-py3-none-any.whl.metadata (2.5 kB)
Collecting protobuf==3.20.3
  Downloading protobuf-3.20.3-cp38-cp38-win_amd64.whl.metadata (699 bytes)
Collecting grpcio>=1.11.0 (from mlagents==0.28.0)
  Downloading grpcio-1.70.0-cp38-cp38-win_amd64.whl.metadata (4.0 kB)
Collecting h5py>=2.9.0 (from mlagents==0.28.0)
  Downloading h5py-3.11.0-cp38-cp38-win_amd64.whl.metadata (2.5 kB)
Collecting mlagents-envs==0.28.0 (from mlagents==0.28.0)
  Using cached mlagents_envs-0.28.0-py3-none-any.whl.metadata (816 bytes)
Collecting numpy<2.0,>=1.13.3 (from mlagents==0.28.0)
  Downloading numpy-1.24.4-cp38-cp38-win_amd64.whl.metadata (5.6 kB)
Collecting Pillow>=4.2.1 (from mlagents==0.28.0)
  Downloading pillow-10.4.0-cp38-cp38-win_amd64.whl.metadata (9.3 kB)
Collecting pyyaml>=3.1.0 (from mlagents==0.28.0)
  Downloading PyYAML-6.0.3-cp38-cp38-win_amd64.whl.metadata (2.2 kB)
Collecting tensorboard>=1.15 (from mlagents==0.28.0)
  Downloading tensorboard-2.14.0-py3-none-any.whl.metadata (1.8 kB)
Collecting attrs>=19.3.0 (from mlagents==0.28.0)
  Downloading attrs-25.3.0-py3-none-any.whl.metadata (10 kB)
Collecting pypiwin32==223 (from mlagents==0.28.0)
  Using cached pypiwin32-223-py3-none-any.whl.metadata (236 bytes)
Collecting cattrs<1.7,>=1.1.0 (from mlagents==0.28.0)
  Using cached cattrs-1.5.0-py3-none-any.whl.metadata (16 kB)
Collecting cloudpickle (from mlagents-envs==0.28.0->mlagents==0.28.0)
  Using cached cloudpickle-3.1.2-py3-none-any.whl.metadata (7.1 kB)
Collecting pywin32>=223 (from pypiwin32==223->mlagents==0.28.0)
  Downloading pywin32-311-cp38-cp38-win_amd64.whl.metadata (9.8 kB)
Collecting absl-py>=0.4 (from tensorboard>=1.15->mlagents==0.28.0)
  Using cached absl_py-2.3.1-py3-none-any.whl.metadata (3.3 kB)
Collecting google-auth<3,>=1.6.3 (from tensorboard>=1.15->mlagents==0.28.0)
  Downloading google_auth-2.43.0-py2.py3-none-any.whl.metadata (6.6 kB)
Collecting google-auth-oauthlib<1.1,>=0.5 (from tensorboard>=1.15->mlagents==0.28.0)
  Downloading google_auth_oauthlib-1.0.0-py2.py3-none-any.whl.metadata (2.7 kB)
Collecting markdown>=2.6.8 (from tensorboard>=1.15->mlagents==0.28.0)
  Using cached Markdown-3.7-py3-none-any.whl.metadata (7.0 kB)
Collecting requests<3,>=2.21.0 (from tensorboard>=1.15->mlagents==0.28.0)
  Downloading requests-2.32.4-py3-none-any.whl.metadata (4.9 kB)
Requirement already satisfied: setuptools>=41.0.0 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from tensorboard>=1.15->mlagents==0.28.0) (75.1.0)
Collecting tensorboard-data-server<0.8.0,>=0.7.0 (from tensorboard>=1.15->mlagents==0.28.0)
  Using cached tensorboard_data_server-0.7.2-py3-none-any.whl.metadata (1.1 kB)
Collecting werkzeug>=1.0.1 (from tensorboard>=1.15->mlagents==0.28.0)
  Downloading werkzeug-3.0.6-py3-none-any.whl.metadata (3.7 kB)
Requirement already satisfied: wheel>=0.26 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from tensorboard>=1.15->mlagents==0.28.0) (0.44.0)
Collecting cachetools<7.0,>=2.0.0 (from google-auth<3,>=1.6.3->tensorboard>=1.15->mlagents==0.28.0)
  Downloading cachetools-5.5.2-py3-none-any.whl.metadata (5.4 kB)
Collecting pyasn1-modules>=0.2.1 (from google-auth<3,>=1.6.3->tensorboard>=1.15->mlagents==0.28.0)
  Downloading pyasn1_modules-0.4.2-py3-none-any.whl.metadata (3.5 kB)
Collecting rsa<5,>=3.1.4 (from google-auth<3,>=1.6.3->tensorboard>=1.15->mlagents==0.28.0)
  Downloading rsa-4.9.1-py3-none-any.whl.metadata (5.6 kB)
Collecting requests-oauthlib>=0.7.0 (from google-auth-oauthlib<1.1,>=0.5->tensorboard>=1.15->mlagents==0.28.0)
  Downloading requests_oauthlib-2.0.0-py2.py3-none-any.whl.metadata (11 kB)
Collecting importlib-metadata>=4.4 (from markdown>=2.6.8->tensorboard>=1.15->mlagents==0.28.0)
  Downloading importlib_metadata-8.5.0-py3-none-any.whl.metadata (4.8 kB)
Collecting charset_normalizer<4,>=2 (from requests<3,>=2.21.0->tensorboard>=1.15->mlagents==0.28.0)
  Downloading charset_normalizer-3.4.4-cp38-cp38-win_amd64.whl.metadata (38 kB)
Collecting idna<4,>=2.5 (from requests<3,>=2.21.0->tensorboard>=1.15->mlagents==0.28.0)
  Downloading idna-3.11-py3-none-any.whl.metadata (8.4 kB)
Collecting urllib3<3,>=1.21.1 (from requests<3,>=2.21.0->tensorboard>=1.15->mlagents==0.28.0)
  Downloading urllib3-2.2.3-py3-none-any.whl.metadata (6.5 kB)
Collecting certifi>=2017.4.17 (from requests<3,>=2.21.0->tensorboard>=1.15->mlagents==0.28.0)
  Downloading certifi-2025.11.12-py3-none-any.whl.metadata (2.5 kB)
Requirement already satisfied: MarkupSafe>=2.1.1 in c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages (from werkzeug>=1.0.1->tensorboard>=1.15->mlagents==0.28.0) (2.1.5)
Collecting zipp>=3.20 (from importlib-metadata>=4.4->markdown>=2.6.8->tensorboard>=1.15->mlagents==0.28.0)
  Downloading zipp-3.20.2-py3-none-any.whl.metadata (3.7 kB)
Collecting pyasn1<0.7.0,>=0.6.1 (from pyasn1-modules>=0.2.1->google-auth<3,>=1.6.3->tensorboard>=1.15->mlagents==0.28.0)
  Downloading pyasn1-0.6.1-py3-none-any.whl.metadata (8.4 kB)
Collecting oauthlib>=3.0.0 (from requests-oauthlib>=0.7.0->google-auth-oauthlib<1.1,>=0.5->tensorboard>=1.15->mlagents==0.28.0)
  Downloading oauthlib-3.3.1-py3-none-any.whl.metadata (7.9 kB)
Using cached mlagents-0.28.0-py3-none-any.whl (164 kB)
Downloading protobuf-3.20.3-cp38-cp38-win_amd64.whl (904 kB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 904.4/904.4 kB 3.2 MB/s eta 0:00:00
Using cached mlagents_envs-0.28.0-py3-none-any.whl (77 kB)
Using cached pypiwin32-223-py3-none-any.whl (1.7 kB)
Downloading attrs-25.3.0-py3-none-any.whl (63 kB)
Using cached cattrs-1.5.0-py3-none-any.whl (19 kB)
Downloading grpcio-1.70.0-cp38-cp38-win_amd64.whl (4.3 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 4.3/4.3 MB 4.5 MB/s eta 0:00:00
Downloading h5py-3.11.0-cp38-cp38-win_amd64.whl (3.0 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 3.0/3.0 MB 3.4 MB/s eta 0:00:00
Downloading numpy-1.24.4-cp38-cp38-win_amd64.whl (14.9 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 14.9/14.9 MB 4.2 MB/s eta 0:00:00
Downloading pillow-10.4.0-cp38-cp38-win_amd64.whl (2.6 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 2.6/2.6 MB 6.7 MB/s eta 0:00:00
Downloading PyYAML-6.0.3-cp38-cp38-win_amd64.whl (160 kB)
Downloading tensorboard-2.14.0-py3-none-any.whl (5.5 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 5.5/5.5 MB 9.1 MB/s eta 0:00:00
Using cached absl_py-2.3.1-py3-none-any.whl (135 kB)
Downloading google_auth-2.43.0-py2.py3-none-any.whl (223 kB)
Downloading google_auth_oauthlib-1.0.0-py2.py3-none-any.whl (18 kB)
Using cached Markdown-3.7-py3-none-any.whl (106 kB)
Downloading pywin32-311-cp38-cp38-win_amd64.whl (9.6 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 9.6/9.6 MB 8.0 MB/s eta 0:00:00
Downloading requests-2.32.4-py3-none-any.whl (64 kB)
Using cached tensorboard_data_server-0.7.2-py3-none-any.whl (2.4 kB)
Downloading werkzeug-3.0.6-py3-none-any.whl (227 kB)
Using cached cloudpickle-3.1.2-py3-none-any.whl (22 kB)
Downloading cachetools-5.5.2-py3-none-any.whl (10 kB)
Downloading certifi-2025.11.12-py3-none-any.whl (159 kB)
Downloading charset_normalizer-3.4.4-cp38-cp38-win_amd64.whl (106 kB)
Downloading idna-3.11-py3-none-any.whl (71 kB)
Downloading importlib_metadata-8.5.0-py3-none-any.whl (26 kB)
Downloading pyasn1_modules-0.4.2-py3-none-any.whl (181 kB)
Downloading requests_oauthlib-2.0.0-py2.py3-none-any.whl (24 kB)
Downloading rsa-4.9.1-py3-none-any.whl (34 kB)
Downloading urllib3-2.2.3-py3-none-any.whl (126 kB)
Downloading oauthlib-3.3.1-py3-none-any.whl (160 kB)
Downloading pyasn1-0.6.1-py3-none-any.whl (83 kB)
Downloading zipp-3.20.2-py3-none-any.whl (9.2 kB)
Installing collected packages: pywin32, zipp, werkzeug, urllib3, tensorboard-data-server, pyyaml, pypiwin32, pyasn1, protobuf, Pillow, oauthlib, numpy, idna, grpcio, cloudpickle, charset_normalizer, certifi, cachetools, attrs, absl-py, rsa, requests, pyasn1-modules, mlagents-envs, importlib-metadata, h5py, cattrs, requests-oauthlib, markdown, google-auth, google-auth-oauthlib, tensorboard, mlagents
Successfully installed Pillow-10.4.0 absl-py-2.3.1 attrs-25.3.0 cachetools-5.5.2 cattrs-1.5.0 certifi-2025.11.12 charset_normalizer-3.4.4 cloudpickle-3.1.2 google-auth-2.43.0 google-auth-oauthlib-1.0.0 grpcio-1.70.0 h5py-3.11.0 idna-3.11 importlib-metadata-8.5.0 markdown-3.7 mlagents-0.28.0 mlagents-envs-0.28.0 numpy-1.24.4 oauthlib-3.3.1 protobuf-3.20.3 pyasn1-0.6.1 pyasn1-modules-0.4.2 pypiwin32-223 pywin32-311 pyyaml-6.0.3 requests-2.32.4 requests-oauthlib-2.0.0 rsa-4.9.1 tensorboard-2.14.0 tensorboard-data-server-0.7.2 urllib3-2.2.3 werkzeug-3.0.6 zipp-3.20.2
(mlagentsRec) PS C:\Users\dexte> mlagents-learn --version
Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 194, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 87, in _run_code
    exec(code, run_globals)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\Scripts\mlagents-learn.exe\__main__.py", line 4, in <module>
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\learn.py", line 13, in <module>
    from mlagents.trainers.trainer_controller import TrainerController
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\trainer_controller.py", line 13, in <module>
    from mlagents.trainers.env_manager import EnvManager, EnvironmentStep
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\env_manager.py", line 12, in <module>
    from mlagents.trainers.policy import Policy
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\policy\__init__.py", line 1, in <module>
    from mlagents.trainers.policy.policy import Policy  # noqa
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\policy\policy.py", line 10, in <module>
    from mlagents.trainers.buffer import AgentBuffer
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\buffer.py", line 97, in <module>
    class AgentBufferField(list):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\buffer.py", line 211, in AgentBufferField
    self, pad_value: np.float = 0, dtype: np.dtype = np.float32
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\numpy\__init__.py", line 305, in __getattr__
    raise AttributeError(__former_attrs__[attr])
AttributeError: module 'numpy' has no attribute 'float'.
`np.float` was a deprecated alias for the builtin `float`. To avoid this error in existing code, use `float` by itself. Doing this will not modify any behavior and is safe. If you specifically wanted the numpy scalar type, use `np.float64` here.
The aliases was originally deprecated in NumPy 1.20; for more details and guidance see the original release note at:
    https://numpy.org/devdocs/release/1.20.0-notes.html#deprecations
(mlagentsRec) PS C:\Users\dexte> pip install numpy==1.23.5
Collecting numpy==1.23.5
  Downloading numpy-1.23.5-cp38-cp38-win_amd64.whl.metadata (2.3 kB)
Downloading numpy-1.23.5-cp38-cp38-win_amd64.whl (14.7 MB)
   ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ 14.7/14.7 MB 9.0 MB/s eta 0:00:00
Installing collected packages: numpy
  Attempting uninstall: numpy
    Found existing installation: numpy 1.24.4
    Uninstalling numpy-1.24.4:
      Successfully uninstalled numpy-1.24.4
Successfully installed numpy-1.23.5
(mlagentsRec) PS C:\Users\dexte> mlagents-learn --version
usage: mlagents-learn.exe [-h] [--env ENV_PATH] [--resume] [--deterministic] [--force] [--run-id RUN_ID]
                          [--initialize-from RUN_ID] [--seed SEED] [--inference] [--base-port BASE_PORT] [--num-envs NUM_ENVS]
                          [--num-areas NUM_AREAS] [--debug] [--env-args ...] [--max-lifetime-restarts MAX_LIFETIME_RESTARTS]
                          [--restarts-rate-limit-n RESTARTS_RATE_LIMIT_N]
                          [--restarts-rate-limit-period-s RESTARTS_RATE_LIMIT_PERIOD_S] [--torch] [--tensorflow]
                          [--results-dir RESULTS_DIR] [--width WIDTH] [--height HEIGHT] [--quality-level QUALITY_LEVEL]
                          [--time-scale TIME_SCALE] [--target-frame-rate TARGET_FRAME_RATE]
                          [--capture-frame-rate CAPTURE_FRAME_RATE] [--no-graphics] [--torch-device DEVICE]
                          [trainer_config_path]
mlagents-learn.exe: error: unrecognized arguments: --version
(mlagentsRec) PS C:\Users\dexte> pip show mlagents mlagents-envs
Name: mlagents
Version: 0.28.0
Summary: Unity Machine Learning Agents
Home-page: https://github.com/Unity-Technologies/ml-agents
Author: Unity Technologies
Author-email: ML-Agents@unity3d.com
License: UNKNOWN
Location: c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages
Requires: attrs, cattrs, grpcio, h5py, mlagents-envs, numpy, Pillow, protobuf, pypiwin32, pyyaml, tensorboard
Required-by:
---
Name: mlagents-envs
Version: 0.28.0
Summary: Unity Machine Learning Agents Interface
Home-page: https://github.com/Unity-Technologies/ml-agents
Author: Unity Technologies
Author-email: ML-Agents@unity3d.com
License: UNKNOWN
Location: c:\users\dexte\anaconda3\envs\mlagentsrec\lib\site-packages
Requires: cloudpickle, grpcio, numpy, Pillow, protobuf, pyyaml
Required-by: mlagents
(mlagentsRec) PS C:\Users\dexte> cd .\anaconda3\envs\mlagentsRec\
(mlagentsRec) PS C:\Users\dexte\anaconda3\envs\mlagentsRec> ls


    Directory: C:\Users\dexte\anaconda3\envs\mlagentsRec


Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
d-----         12/4/2025   2:35 PM                conda-meta
d-----         12/4/2025   2:35 PM                DLLs
d-----         12/4/2025   2:35 PM                etc
d-----         12/4/2025   2:35 PM                include
d-----         12/4/2025   2:35 PM                Lib
d-----         12/4/2025   2:35 PM                Library
d-----         12/4/2025   2:35 PM                libs
d-----         12/4/2025   3:39 PM                Scripts
d-----         12/4/2025   2:40 PM                share
d-----         12/4/2025   2:35 PM                tcl
d-----         12/4/2025   2:35 PM                Tools
-a----         12/4/2025   2:35 PM              0 .nonadmin
-a----          5/6/2022   8:21 AM          21984 api-ms-win-core-console-l1-1-0.dll
-a----          5/6/2022   8:29 AM          21976 api-ms-win-core-console-l1-2-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-core-datetime-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-core-debug-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21976 api-ms-win-core-errorhandling-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21992 api-ms-win-core-fibers-l1-1-0.dll
-a----          5/6/2022   8:21 AM          26088 api-ms-win-core-file-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21976 api-ms-win-core-file-l1-2-0.dll
-a----          5/6/2022   8:22 AM          21976 api-ms-win-core-file-l2-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-core-handle-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-core-heap-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-core-interlocked-l1-1-0.dll
-a----          5/6/2022   8:22 AM          22008 api-ms-win-core-libraryloader-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-core-localization-l1-2-0.dll
-a----          5/6/2022   8:21 AM          21976 api-ms-win-core-memory-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-core-namedpipe-l1-1-0.dll
-a----          5/6/2022   8:21 AM          22008 api-ms-win-core-processenvironment-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21976 api-ms-win-core-processthreads-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21976 api-ms-win-core-processthreads-l1-1-1.dll
-a----          5/6/2022   8:21 AM          21992 api-ms-win-core-profile-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-core-rtlsupport-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21976 api-ms-win-core-string-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21976 api-ms-win-core-synch-l1-1-0.dll
-a----          5/6/2022   8:22 AM          21976 api-ms-win-core-synch-l1-2-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-core-sysinfo-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21976 api-ms-win-core-timezone-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21992 api-ms-win-core-util-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-crt-conio-l1-1-0.dll
-a----          5/6/2022   8:21 AM          26080 api-ms-win-crt-convert-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-crt-environment-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-crt-filesystem-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-crt-heap-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-crt-locale-l1-1-0.dll
-a----          5/6/2022   8:21 AM          30184 api-ms-win-crt-math-l1-1-0.dll
-a----          5/6/2022   8:21 AM          30176 api-ms-win-crt-multibyte-l1-1-0.dll
-a----          5/6/2022   8:21 AM          75232 api-ms-win-crt-private-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-crt-process-l1-1-0.dll
-a----          5/6/2022   8:21 AM          26104 api-ms-win-crt-runtime-l1-1-0.dll
-a----          5/6/2022   8:21 AM          26080 api-ms-win-crt-stdio-l1-1-0.dll
-a----          5/6/2022   8:22 AM          26072 api-ms-win-crt-string-l1-1-0.dll
-a----          5/6/2022   8:21 AM          21984 api-ms-win-crt-time-l1-1-0.dll
-a----          5/6/2022   8:21 AM          22000 api-ms-win-crt-utility-l1-1-0.dll
-a----         7/10/2025   7:08 PM         324720 concrt140.dll
-a----         8/24/2023  12:36 PM          13937 LICENSE_PYTHON.txt
-a----         7/10/2025   7:08 PM         557648 msvcp140.dll
-a----         7/10/2025   7:08 PM          35952 msvcp140_1.dll
-a----         7/10/2025   7:08 PM         280176 msvcp140_2.dll
-a----         7/10/2025   7:08 PM          50288 msvcp140_atomic_wait.dll
-a----         7/10/2025   7:08 PM          31880 msvcp140_codecvt_ids.dll
-a----         9/11/2023   6:40 AM          95232 python.exe
-a----         9/11/2023   6:40 AM         454656 python.pdb
-a----         9/11/2023   6:39 AM          51712 python3.dll
-a----         9/11/2023   6:39 AM        4878336 python38.dll
-a----         9/11/2023   6:39 AM       12783616 python38.pdb
-a----         9/11/2023   6:40 AM          93696 pythonw.exe
-a----         9/11/2023   6:40 AM         454656 pythonw.pdb
-a----          5/6/2022   8:22 AM        1123808 ucrtbase.dll
-a----         7/10/2025   7:08 PM         418896 vcamp140.dll
-a----         7/10/2025   7:08 PM         352336 vccorlib140.dll
-a----         7/10/2025   7:08 PM         193184 vcomp140.dll
-a----         7/10/2025   7:08 PM         124496 vcruntime140.dll
-a----         7/10/2025   7:08 PM          49744 vcruntime140_1.dll
-a----         7/10/2025   7:08 PM          38480 vcruntime140_threads.dll
-a----         9/11/2023   6:40 AM         523264 venvlauncher.exe
-a----         9/11/2023   6:40 AM         522240 venvwlauncher.exe


(mlagentsRec) PS C:\Users\dexte\anaconda3\envs\mlagentsRec> conda activate mlagentsRec
(mlagentsRec) PS C:\Users\dexte\anaconda3\envs\mlagentsRec> cd C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML
(mlagentsRec) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> mlagents-learn Assets/Tasks/3DBPP/Configs/CornerPlacement_BC.yaml --run-id=CornerPlacement_BC_v4 --force

            ┐  ╖
        ╓╖╬│╡  ││╬╖╖
    ╓╖╬│││││┘  ╬│││││╬╖
 ╖╬│││││╬╜        ╙╬│││││╖╖                               ╗╗╗
 ╬╬╬╬╖││╦╖        ╖╬││╗╣╣╣╬      ╟╣╣╬    ╟╣╣╣             ╜╜╜  ╟╣╣
 ╬╬╬╬╬╬╬╬╖│╬╖╖╓╬╪│╓╣╣╣╣╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╒╣╣╖╗╣╣╣╗   ╣╣╣ ╣╣╣╣╣╣ ╟╣╣╖   ╣╣╣
 ╬╬╬╬┐  ╙╬╬╬╬│╓╣╣╣╝╜  ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╣╙ ╙╣╣╣  ╣╣╣ ╙╟╣╣╜╙  ╫╣╣  ╟╣╣
 ╬╬╬╬┐     ╙╬╬╣╣      ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣     ╣╣╣┌╣╣╜
 ╬╬╬╜       ╬╬╣╣      ╙╝╣╣╬      ╙╣╣╣╗╖╓╗╣╣╣╜ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣╦╓    ╣╣╣╣╣
 ╙   ╓╦╖    ╬╬╣╣   ╓╗╗╖            ╙╝╣╣╣╣╝╜   ╘╝╝╜   ╝╝╝  ╝╝╝   ╙╣╣╣    ╟╣╣╣
   ╩╬╬╬╬╬╬╦╦╬╬╣╣╗╣╣╣╣╣╣╣╝                                             ╫╣╣╣╣
      ╙╬╬╬╬╬╬╬╣╣╣╣╣╣╝╜
          ╙╬╬╬╣╣╣╜
             ╙

 Version information:
  ml-agents: 0.28.0,
  ml-agents-envs: 0.28.0,
  Communicator API: 1.5.0,
  PyTorch: 2.0.1+cu118
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 2.0.2 and communication version 1.5.0
[INFO] Connected new brain: CornerPlacementAgent?team=0
[INFO] Hyperparameters for behavior name CornerPlacementAgent:
        trainer_type:   ppo
        hyperparameters:
          batch_size:   1024
          buffer_size:  10240
          learning_rate:        0.0003
          beta: 0.005
          epsilon:      0.2
          lambd:        0.95
          num_epoch:    3
          learning_rate_schedule:       linear
          beta_schedule:        linear
          epsilon_schedule:     linear
        network_settings:
          normalize:    False
          hidden_units: 128
          num_layers:   2
          vis_encode_type:      simple
          memory:       None
          goal_conditioning_type:       hyper
          deterministic:        False
        reward_signals:
          extrinsic:
            gamma:      0.99
            strength:   1.0
            network_settings:
              normalize:        False
              hidden_units:     128
              num_layers:       2
              vis_encode_type:  simple
              memory:   None
              goal_conditioning_type:   hyper
              deterministic:    False
        init_path:      None
        keep_checkpoints:       5
        checkpoint_interval:    50000
        max_steps:      200000
        time_horizon:   64
        summary_freq:   10000
        threaded:       False
        self_play:      None
        behavioral_cloning:
          demo_path:    Assets/Tasks/3DBPP/Demonstrations/CornerPlacementAgent_2.demo
          steps:        50000
          strength:     0.5
          samples_per_update:   512
          num_epoch:    None
          batch_size:   None
C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\torch\networks.py:91: UserWarning: Creating a tensor from a list of numpy.ndarrays is extremely slow. Please consider converting the list to a single numpy.ndarray with numpy.array() before converting to a tensor. (Triggered internally at C:\actions-runner\_work\pytorch\pytorch\builder\windows\pytorch\torch\csrc\utils\tensor_new.cpp:248.)
  enc.update_normalization(torch.as_tensor(vec_input))
[INFO] CornerPlacementAgent. Step: 10000. Time Elapsed: 191.345 s. Mean Reward: -24.985. Std of Reward: 14.664. Training.
C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\torch\utils.py:320: UserWarning: The use of `x.T` on tensors of dimension other than 2 to reverse their shape is deprecated and it will throw an error in a future release. Consider `x.mT` to transpose batches of matrices or `x.permute(*torch.arange(x.ndim - 1, -1, -1))` to reverse the dimensions of a tensor. (Triggered internally at C:\actions-runner\_work\pytorch\pytorch\builder\windows\pytorch\aten\src\ATen\native\TensorShape.cpp:3575.)
  return (tensor.T * masks).sum() / torch.clamp(
[INFO] CornerPlacementAgent. Step: 20000. Time Elapsed: 366.138 s. Mean Reward: -22.611. Std of Reward: 15.733. Training.
[WARNING] Restarting worker[0] after 'Communicator has exited.'
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
============= Diagnostic Run torch.onnx.export version 2.0.1+cu118 =============
verbose: False, log level: Level.ERROR
======================= 0 NONE 0 NOTE 0 WARNING 0 ERROR ========================

Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\trainer_controller.py", line 176, in start_learning
    n_steps = self.advance(env_manager)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\trainer_controller.py", line 234, in advance
    new_step_infos = env_manager.get_steps()
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\env_manager.py", line 124, in get_steps
    new_step_infos = self._step()
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 420, in _step
    self._restart_failed_workers(step)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 328, in _restart_failed_workers
    self.reset(self.env_parameters)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\env_manager.py", line 68, in reset
    self.first_step_infos = self._reset_env(config)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 446, in _reset_env
    ew.previous_step = EnvironmentStep(ew.recv().payload, ew.worker_id, {}, {})
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\subprocess_env_manager.py", line 101, in recv
    raise env_exception
mlagents_envs.exception.UnityTimeOutException: The Unity environment took too long to respond. Make sure that :
         The environment does not need user interaction to launch
         The Agents' Behavior Parameters > Behavior Type is set to "Default"
         The environment and the Python interface have compatible versions.
         If you're running on a headless server without graphics support, turn off display by either passing --no-graphics option or build your Unity executable as server build.

During handling of the above exception, another exception occurred:

Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\torch\onnx\_internal\onnx_proto_utils.py", line 219, in _add_onnxscript_fn
    import onnx
ModuleNotFoundError: No module named 'onnx'

The above exception was the direct cause of the following exception:

Traceback (most recent call last):
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 194, in _run_module_as_main
    return _run_code(code, main_globals, None,
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\runpy.py", line 87, in _run_code
    exec(code, run_globals)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\Scripts\mlagents-learn.exe\__main__.py", line 7, in <module>
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\learn.py", line 260, in main
    run_cli(parse_command_line())
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\learn.py", line 256, in run_cli
    run_training(run_seed, options, num_areas)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\learn.py", line 132, in run_training
    tc.start_learning(env_manager)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\trainer_controller.py", line 201, in start_learning
    self._save_models()
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\trainer_controller.py", line 80, in _save_models
    self.trainers[brain_name].save_model()
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\trainer\rl_trainer.py", line 185, in save_model
    model_checkpoint = self._checkpoint()
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents_envs\timers.py", line 305, in wrapped
    return func(*args, **kwargs)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\trainer\rl_trainer.py", line 157, in _checkpoint
    export_path, auxillary_paths = self.model_saver.save_checkpoint(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\model_saver\torch_model_saver.py", line 60, in save_checkpoint
    self.export(checkpoint_path, behavior_name)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\model_saver\torch_model_saver.py", line 65, in export
    self.exporter.export_policy_model(output_filepath)
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\torch\model_serialization.py", line 164, in export_policy_model
    torch.onnx.export(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\torch\onnx\utils.py", line 506, in export
    _export(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\torch\onnx\utils.py", line 1620, in _export
    proto = onnx_proto_utils._add_onnxscript_fn(
  File "C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\torch\onnx\_internal\onnx_proto_utils.py", line 221, in _add_onnxscript_fn
    raise errors.OnnxExporterError("Module onnx is not installed!") from e
torch.onnx.errors.OnnxExporterError: Module onnx is not installed!
(mlagentsRec) PS C:\Users\dexte\anaconda3\envs\FirstMLEnv\3DBPP_ML\3DBPP_ML> mlagents-learn Assets/Tasks/3DBPP/Configs/CornerPlacement_BC.yaml --run-id=CornerPA_NewNeur_001

            ┐  ╖
        ╓╖╬│╡  ││╬╖╖
    ╓╖╬│││││┘  ╬│││││╬╖
 ╖╬│││││╬╜        ╙╬│││││╖╖                               ╗╗╗
 ╬╬╬╬╖││╦╖        ╖╬││╗╣╣╣╬      ╟╣╣╬    ╟╣╣╣             ╜╜╜  ╟╣╣
 ╬╬╬╬╬╬╬╬╖│╬╖╖╓╬╪│╓╣╣╣╣╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╒╣╣╖╗╣╣╣╗   ╣╣╣ ╣╣╣╣╣╣ ╟╣╣╖   ╣╣╣
 ╬╬╬╬┐  ╙╬╬╬╬│╓╣╣╣╝╜  ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╣╙ ╙╣╣╣  ╣╣╣ ╙╟╣╣╜╙  ╫╣╣  ╟╣╣
 ╬╬╬╬┐     ╙╬╬╣╣      ╫╣╣╣╬      ╟╣╣╬    ╟╣╣╣ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣     ╣╣╣┌╣╣╜
 ╬╬╬╜       ╬╬╣╣      ╙╝╣╣╬      ╙╣╣╣╗╖╓╗╣╣╣╜ ╟╣╣╬   ╣╣╣  ╣╣╣  ╟╣╣╦╓    ╣╣╣╣╣
 ╙   ╓╦╖    ╬╬╣╣   ╓╗╗╖            ╙╝╣╣╣╣╝╜   ╘╝╝╜   ╝╝╝  ╝╝╝   ╙╣╣╣    ╟╣╣╣
   ╩╬╬╬╬╬╬╦╦╬╬╣╣╗╣╣╣╣╣╣╣╝                                             ╫╣╣╣╣
      ╙╬╬╬╬╬╬╬╣╣╣╣╣╣╝╜
          ╙╬╬╬╣╣╣╜
             ╙

 Version information:
  ml-agents: 0.28.0,
  ml-agents-envs: 0.28.0,
  Communicator API: 1.5.0,
  PyTorch: 2.0.1+cu118
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.
[INFO] Connected to Unity environment with package version 2.0.2 and communication version 1.5.0
[INFO] Connected new brain: CornerPlacementAgent?team=0
[INFO] Hyperparameters for behavior name CornerPlacementAgent:
        trainer_type:   ppo
        hyperparameters:
          batch_size:   1024
          buffer_size:  10240
          learning_rate:        0.0003
          beta: 0.005
          epsilon:      0.2
          lambd:        0.95
          num_epoch:    3
          learning_rate_schedule:       linear
          beta_schedule:        linear
          epsilon_schedule:     linear
        network_settings:
          normalize:    False
          hidden_units: 128
          num_layers:   2
          vis_encode_type:      simple
          memory:       None
          goal_conditioning_type:       hyper
          deterministic:        False
        reward_signals:
          extrinsic:
            gamma:      0.99
            strength:   1.0
            network_settings:
              normalize:        False
              hidden_units:     128
              num_layers:       2
              vis_encode_type:  simple
              memory:   None
              goal_conditioning_type:   hyper
              deterministic:    False
        init_path:      None
        keep_checkpoints:       5
        checkpoint_interval:    50000
        max_steps:      200000
        time_horizon:   64
        summary_freq:   10000
        threaded:       False
        self_play:      None
        behavioral_cloning:
          demo_path:    Assets/Tasks/3DBPP/Demonstrations/CornerPAnewHeur_4.demo
          steps:        50000
          strength:     0.5
          samples_per_update:   512
          num_epoch:    None
          batch_size:   None
C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\torch\networks.py:91: UserWarning: Creating a tensor from a list of numpy.ndarrays is extremely slow. Please consider converting the list to a single numpy.ndarray with numpy.array() before converting to a tensor. (Triggered internally at C:\actions-runner\_work\pytorch\pytorch\builder\windows\pytorch\torch\csrc\utils\tensor_new.cpp:248.)
  enc.update_normalization(torch.as_tensor(vec_input))
[INFO] CornerPlacementAgent. Step: 10000. Time Elapsed: 156.462 s. Mean Reward: -25.309. Std of Reward: 14.679. Training.
C:\Users\dexte\anaconda3\envs\mlagentsRec\lib\site-packages\mlagents\trainers\torch\utils.py:320: UserWarning: The use of `x.T` on tensors of dimension other than 2 to reverse their shape is deprecated and it will throw an error in a future release. Consider `x.mT` to transpose batches of matrices or `x.permute(*torch.arange(x.ndim - 1, -1, -1))` to reverse the dimensions of a tensor. (Triggered internally at C:\actions-runner\_work\pytorch\pytorch\builder\windows\pytorch\aten\src\ATen\native\TensorShape.cpp:3575.)
  return (tensor.T * masks).sum() / torch.clamp(
[INFO] CornerPlacementAgent. Step: 20000. Time Elapsed: 276.586 s. Mean Reward: -23.327. Std of Reward: 15.736. Training.
[INFO] CornerPlacementAgent. Step: 30000. Time Elapsed: 413.365 s. Mean Reward: -20.324. Std of Reward: 17.215. Training.
[WARNING] Restarting worker[0] after 'Communicator has exited.'
[INFO] Listening on port 5004. Start training by pressing the Play button in the Unity Editor.